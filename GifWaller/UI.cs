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
            if (!string.IsNullOrEmpty(File)) pbox_prev.Image = Image.FromFile(File);
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
                if (Start())
                {
                    PowerBtn.Text = "✔";                    //haha unicode emoji go brrrr
                    PowerBtn.ForeColor = Color.SpringGreen;

                    Activate();

                    return;
                }
            }
            if (Running)
            {
                Stop();

                PowerBtn.Text = "❌";
                PowerBtn.ForeColor = Color.Crimson;

                Activate();

                return;
            }
        }

        private void BtnPosiUp_Click(object sender, EventArgs e)
        {
            if (Running) Waller.SetDesktopLocation(CurrPosiX, CurrPosiY -= Snapf);

            ReDrawDesktop();
        }

        private void BtnPosiLeft_Click(object sender, EventArgs e)
        {
            if (Running) Waller.SetDesktopLocation(CurrPosiX -= Snapf, CurrPosiY);

            ReDrawDesktop();
        }

        private void BtnPosiRight_Click(object sender, EventArgs e)
        {
            if (Running) Waller.SetDesktopLocation(CurrPosiX += Snapf, CurrPosiY);

            ReDrawDesktop();
        }

        private void BtnPosiDown_Click(object sender, EventArgs e)
        {
            if (Running) Waller.SetDesktopLocation(CurrPosiX, CurrPosiY += Snapf);

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
                if (byte.TryParse(TextBox_PosiSnap.Text, out Snapf)) { }

                else
                {
                    TextBox_PosiSnap.Text = "1";
                    Snapf = 1;
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
                if (byte.TryParse(TextBox_ScrID.Text, out ScrID) && ScrID > 0 && ScrID <= Screen.AllScreens.Length)
                {
                    Restart();
                }

                else
                {
                    TextBox_ScrID.Text = "1";
                    ScrID = 1;

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
                if (byte.TryParse(Text_Box_PaddingH.Text, out PadH))
                {
                    Restart();
                }

                else
                {
                    Text_Box_PaddingH.Text = "1";
                    PadH = 1;

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
                if (byte.TryParse(Text_Box_PaddingW.Text, out PadW))
                {
                    Restart();
                }

                else
                {
                    Text_Box_PaddingW.Text = "1";
                    PadW = 1;

                    Restart();
                }

                Text_Box_PaddingW.BackColor = Color.GhostWhite;
            }
        }

        private void pbox_prev_Click(object sender, EventArgs e)
        {
            if (Receive_File())
            {
                pbox_prev.Image = Image.FromFile(File);

                if (Running) PBox.Image = Image.FromFile(File);
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Setting.ShowDialog();
        }
    }
}
