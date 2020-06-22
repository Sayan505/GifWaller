using System;
using System.Reflection;
using System.Windows.Forms;

namespace GifWaller
{
    public partial class Settings : Form
    {
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

        private void Link_Author_Sayan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Sayan505/GifWaller");
        }
    }
}
