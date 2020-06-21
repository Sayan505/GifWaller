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
            FormClosing += new FormClosingEventHandler(EXIT);
            HTCAPTION.MouseDown += new MouseEventHandler(Drag_Move);
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
                Icon = SystemIcons.Application,
                Visible = true,
            };
            notifyIcon.MouseDown += new MouseEventHandler(Tray_Handler);
        }

        private void Tray_Handler(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Visible)
                {
                    hide();
                }
                else
                {
                    show();
                }

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
            if (!string.IsNullOrEmpty(file)) pbox_prev.Image = Image.FromFile(file);
            pbox_prev.Show();

            Show();
            Activate();
        }

        private void EXIT(object sender, FormClosingEventArgs e)
        {
            stop();
        }

        private void PowerBtn_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                if (start())
                {
                    PowerBtn.Text = "✔";                    //haha unicode emoji go brrrr
                    PowerBtn.ForeColor = Color.SpringGreen;

                    Activate();

                    return;
                }
            }
            if (running)
            {
                stop();

                PowerBtn.Text = "❌";
                PowerBtn.ForeColor = Color.Crimson;

                Activate();

                return;
            }
        }

        private void BtnPosiUp_Click(object sender, EventArgs e)
        {
            if (running) waller.SetDesktopLocation(CurrPosiX, CurrPosiY -= snapf);

            ReDrawDesktop();
        }

        private void BtnPosiLeft_Click(object sender, EventArgs e)
        {
            if (running) waller.SetDesktopLocation(CurrPosiX -= snapf, CurrPosiY);

            ReDrawDesktop();
        }

        private void BtnPosiRight_Click(object sender, EventArgs e)
        {
            if (running) waller.SetDesktopLocation(CurrPosiX += snapf, CurrPosiY);

            ReDrawDesktop();
        }

        private void BtnPosiDown_Click(object sender, EventArgs e)
        {
            if (running) waller.SetDesktopLocation(CurrPosiX, CurrPosiY += snapf);

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
                if (byte.TryParse(TextBox_PosiSnap.Text, out snapf)) { }

                else
                {
                    TextBox_PosiSnap.Text = "1";
                    snapf = 1;
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
                if (byte.TryParse(TextBox_ScrID.Text, out scrID) && scrID > 0 && scrID <= Screen.AllScreens.Length)
                {
                    restart();
                }

                else
                {
                    TextBox_ScrID.Text = "1";
                    scrID = 1;

                    restart();
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
                if (byte.TryParse(Text_Box_PaddingH.Text, out padH))
                {
                    restart();
                }

                else
                {
                    Text_Box_PaddingH.Text = "1";
                    padH = 1;

                    restart();
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
                if (byte.TryParse(Text_Box_PaddingW.Text, out padW))
                {
                    restart();
                }

                else
                {
                    Text_Box_PaddingW.Text = "1";
                    padW = 1;

                    restart();
                }

                Text_Box_PaddingW.BackColor = Color.GhostWhite;
            }
        }

        private void pbox_prev_Click(object sender, EventArgs e)
        {
            if (receive_file())
            {
                pbox_prev.Image = Image.FromFile(file);

                if (running) pbox.Image = Image.FromFile(file);
            }
        }
    }
}
