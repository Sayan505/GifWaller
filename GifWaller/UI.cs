using System;
using System.Drawing;
using System.Windows.Forms;

namespace GifWaller
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();

            //custom events
            FormClosing         += new FormClosingEventHandler(EXIT);
            HTCAPTION.MouseDown += new MouseEventHandler(Drag_Move);

            Setting.BtnDefaults.Click += new EventHandler(SETDefault);
            Setting.BtnSave.Click     += new EventHandler(SETSave);
            Setting.BtnLoad.Click     += new EventHandler(SETLoad);
        }

        private void Drag_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WINAPI.ReleaseCapture();

                WINAPI.SendMessage(Handle, WINAPI.WM_NCLBUTTONDOWN, WINAPI.HTCAPTION, 0);
            }
        }

        private void UI_Load(object sender, EventArgs e)
        {
            ReDrawDesktop();

            NotifyIcon notifyIcon = new NotifyIcon()
            {
                Icon    = SystemIcons.Application,
                Visible = true,
            };
            notifyIcon.MouseDown += new MouseEventHandler(Tray_Handler);

            SETLoad(this, EventArgs.Empty); //load last settings if any
        }

        private void Tray_Handler(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Visible) hide();
                else show();

            }
        }

        private void hide()
        {
            Hide();

            pbox_prev.Image = null;
            pbox_prev.Hide();
        }

        private void show()
        {
            if (!string.IsNullOrEmpty(SET.File)) pbox_prev.Image = Img;
            pbox_prev.Show();

            Show();
            Activate();
        }

        private void EXIT(object sender, FormClosingEventArgs e)
        {
            Stop();
        }

        private void PowerBtn_Click(object sender, EventArgs e)
        {
            if (!Running)
            {
                if (Start()) return;
            }
            if (Running)
            {
                Stop();

                return;
            }
        }

        private void BtnPosiUp_Click(object sender, EventArgs e)
        {
            if (Running) Waller.SetDesktopLocation(SET.CurrPosiX, SET.CurrPosiY -= SET.Snapf);

            ReDrawDesktop();
        }

        private void BtnPosiLeft_Click(object sender, EventArgs e)
        {
            if (Running) Waller.SetDesktopLocation(SET.CurrPosiX -= SET.Snapf, SET.CurrPosiY);

            ReDrawDesktop();
        }

        private void BtnPosiRight_Click(object sender, EventArgs e)
        {
            if (Running) Waller.SetDesktopLocation(SET.CurrPosiX += SET.Snapf, SET.CurrPosiY);

            ReDrawDesktop();
        }

        private void BtnPosiDown_Click(object sender, EventArgs e)
        {
            if (Running) Waller.SetDesktopLocation(SET.CurrPosiX, SET.CurrPosiY += SET.Snapf);

            ReDrawDesktop();
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnHide_Click(object sender, EventArgs e)
        {
            hide();
        }

        private void TextBox_PosiSnap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (byte.TryParse(TextBox_PosiSnap.Text, out SET.Snapf)) { }

                else
                {
                    TextBox_PosiSnap.Text = "1";
                    SET.Snapf = 1;
                }

                TextBox_PosiSnap.BackColor = Color.GhostWhite;
            }

        }

        private void TextBox_PosiSnap_TextChanged(object sender, EventArgs e)
        {
            TextBox_PosiSnap.BackColor = Color.LightPink;
        }

        private void TextBox_ScrID_TextChanged(object sender, EventArgs e)
        {
            TextBox_ScrID.BackColor = Color.LightPink;
        }

        private void TextBox_ScrID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (byte.TryParse(TextBox_ScrID.Text, out SET.ScrID) && SET.ScrID > 0 && SET.ScrID <= Screen.AllScreens.Length)
                {
                    Restart();
                }

                else
                {
                    TextBox_ScrID.Text = "1";
                    SET.ScrID = 1;

                    Restart();
                }

                TextBox_ScrID.BackColor = Color.GhostWhite;
            }

        }

        private void Text_Box_PaddingH_TextChanged(object sender, EventArgs e)
        {
            Text_Box_PaddingH.BackColor = Color.LightPink;
        }

        private void Text_Box_PaddingH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (byte.TryParse(Text_Box_PaddingH.Text, out SET.PadH))
                {
                    Restart();
                }

                else
                {
                    Text_Box_PaddingH.Text = "1";
                    SET.PadH = 1;

                    Restart();
                }

                Text_Box_PaddingH.BackColor = Color.GhostWhite;
            }
        }

        private void Text_Box_PaddingW_TextChanged(object sender, EventArgs e)
        {
            Text_Box_PaddingW.BackColor = Color.LightPink;
        }

        private void Text_Box_PaddingW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (byte.TryParse(Text_Box_PaddingW.Text, out SET.PadW))
                {
                    Restart();
                }

                else
                {
                    Text_Box_PaddingW.Text = "1";
                    SET.PadW = 1;

                    Restart();
                }

                Text_Box_PaddingW.BackColor = Color.GhostWhite;
            }
        }

        private void pbox_prev_Click(object sender, EventArgs e)
        {
            if (Receive_File())
            {
                pbox_prev.Image = Img;

                if (Running) PBox.Image = Img;
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Setting.ShowDialog();
        }

        private void BtnReDraw_Click(object sender, EventArgs e)
        {
            ReDrawDesktop();
        }
    }
}
