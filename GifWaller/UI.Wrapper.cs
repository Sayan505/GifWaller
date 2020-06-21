using System.Drawing;
using System.Windows.Forms;

namespace GifWaller
{
    public partial class UI
    {
        bool running = false;

        private Form waller;
        private PictureBox pbox;
        private OpenFileDialog fileDialog = new OpenFileDialog()
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
        private int CurrPosiX = 0;
        private int CurrPosiY = 0;

        //image padding (generally, 1px required)
        //A red outline (form background) might show up on weird resolutions. That's when you need to configure padding.
        private byte padW = 1;
        private byte padH = 1;

        //image move snapping
        private byte snapf = 1;

        //image reso
        private byte scrID = 1;

        //gif path
        private string file = string.Empty;
        /*          SETTINGS            */

        private bool receive_file()
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                file = fileDialog.FileName;

                Activate();

                return true;
            }
            else
            {
                Activate();

                return false;
            }
        }

        private bool start()
        {
            if (string.IsNullOrEmpty(file))
                if (!receive_file()) return false;

            if (!running)
            {
                waller = new Form
                {
                    FormBorderStyle = FormBorderStyle.None,
                    StartPosition = FormStartPosition.Manual,            //0 = big; 1 = small.
                    Location = new Point(CurrPosiX, CurrPosiY),
                    Size = new Size(Screen.AllScreens[scrID - 1].WorkingArea.Size.Width, Screen.AllScreens[scrID - 1].WorkingArea.Size.Height)
                };

                pbox = new PictureBox
                {
                    Image = Image.FromFile(file),
                    BorderStyle = BorderStyle.None,
                    Location = new Point(0, 0),
                    Padding = new Padding(0),
                    BackColor = Color.Red,
                    Size = new Size(Screen.AllScreens[scrID - 1].WorkingArea.Size.Width + padW, Screen.AllScreens[scrID - 1].WorkingArea.Size.Height + padH),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };

                pbox_prev.Image = Image.FromFile(file);

                running = true;

                waller.Controls.Add(pbox);
                WINAPI.SetParent(waller.Handle, Engine.WorkerW);    //set parent handle to WorkerW

                waller.Show();

                return true;
            }

            return false;
        }

        private void stop()
        {
            if (running)
            {
                running = false;

                pbox.Dispose();
                waller.Dispose();

                ReDrawDesktop();
            }
        }

        private void restart()
        {
            if (running)
            {
                stop();
                start();
            }
        }

        private void ReDrawDesktop()
        {
            WINAPI.SendMessage(Engine.progman, 0x0034, 4, 0);   //re-draw the desktop
        }
    }
}
