using System.Drawing;
using System.Windows.Forms;

namespace GifWaller
{
    public partial class UI
    {
        bool Running = false;

        Settings Setting = new Settings();
        private Form Waller;
        private PictureBox PBox;
        private OpenFileDialog FileDialog = new OpenFileDialog()
        {
            InitialDirectory = @"C:\",
            Title = "Open A GIF File",
            DefaultExt = "gif",
            Filter = "GIF Files (*.gif)|*.gif|All Files (*.*)|*",
            Multiselect = false,
            AddExtension = true,
            CheckPathExists = true,
            CheckFileExists = true,
            RestoreDirectory = false
        };


        /*          SETTINGS            */
        //image posi
        internal static int CurrPosiX = 0;
        internal static int CurrPosiY = 0;

        //image padding (generally, 1px required)
        //A red outline (form background) might show up on weird resolutions. That's when you need to configure padding.
        internal static byte PadH = 1;
        internal static byte PadW = 1;

        //image move snapping
        internal static byte Snapf = 1;

        //image reso
        internal static byte ScrID = 1;

        //gif path
        internal static string File = string.Empty;
        /*          SETTINGS            */

        private bool Receive_File()
        {
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                File = FileDialog.FileName;

                Activate();

                return true;
            }
            else
            {
                Activate();

                return false;
            }
        }

        private bool Start()
        {
            if (string.IsNullOrEmpty(File))
                if (!Receive_File()) return false;

            if (!Running)
            {
                Waller = new Form
                {
                    FormBorderStyle = FormBorderStyle.None,
                    StartPosition = FormStartPosition.Manual,            //0 = big; 1 = small.
                    Location = new Point(CurrPosiX, CurrPosiY),
                    Size = new Size(Screen.AllScreens[ScrID - 1].WorkingArea.Size.Width, Screen.AllScreens[ScrID - 1].WorkingArea.Size.Height)
                };

                PBox = new PictureBox
                {
                    Image = Image.FromFile(File),
                    BorderStyle = BorderStyle.None,
                    Location = new Point(0, 0),
                    Padding = new Padding(0),
                    BackColor = Color.Red,
                    Size = new Size(Screen.AllScreens[ScrID - 1].WorkingArea.Size.Width + PadW, Screen.AllScreens[ScrID - 1].WorkingArea.Size.Height + PadH),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };

                pbox_prev.Image = Image.FromFile(File);

                Running = true;

                Waller.Controls.Add(PBox);
                WINAPI.SetParent(Waller.Handle, Engine.WorkerW);    //set parent handle to WorkerW

                Waller.Show();

                return true;
            }

            return false;
        }

        private void Stop()
        {
            if (Running)
            {
                Running = false;

                PBox.Dispose();
                Waller.Dispose();

                ReDrawDesktop();
            }
        }

        private void Restart()
        {
            if (Running)
            {
                Stop();
                Start();
            }
        }

        private void ReDrawDesktop()
        {
            WINAPI.SendMessage(Engine.progman, 0x0034, 4, 0);   //re-draw the desktop
        }
    }
}
