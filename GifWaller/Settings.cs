using System;
using System.IO;
using System.Windows.Forms;

namespace GifWaller
{
    public partial class Settings : Form
    {

        /*          SETTINGS            */
        internal struct DefSET
        {
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
        }
        /*          SETTINGS            */

        public Settings()
        {
            InitializeComponent();

            HTCAPTION_Settings.MouseDown += new MouseEventHandler(Drag_Move);
        }

        private void Drag_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WINAPI.ReleaseCapture();

                WINAPI.SendMessage(Handle, WINAPI.WM_NCLBUTTONDOWN, WINAPI.HTCAPTION, 0);
            }
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {


        }

        private void BtnDefaults_Click(object sender, EventArgs e)
        {

        }

        private void Link_Author_Sayan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Sayan505/GifWaller");
        }
    }
}
