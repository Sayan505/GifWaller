namespace GifWaller
{
    partial class UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.HTCAPTION = new System.Windows.Forms.Panel();
            this.BtnHide = new System.Windows.Forms.Button();
            this.BtnX = new System.Windows.Forms.Button();
            this.PowerBtn = new System.Windows.Forms.Button();
            this.BtnPosiLeft = new System.Windows.Forms.Button();
            this.BtnPosiDown = new System.Windows.Forms.Button();
            this.BtnPosiRight = new System.Windows.Forms.Button();
            this.BtnPosiUp = new System.Windows.Forms.Button();
            this.TextBox_PosiSnap = new System.Windows.Forms.TextBox();
            this.TextBox_ScrID = new System.Windows.Forms.TextBox();
            this.Label_Reso = new System.Windows.Forms.Label();
            this.Text_Box_PaddingH = new System.Windows.Forms.TextBox();
            this.Label_Padding = new System.Windows.Forms.Label();
            this.Text_Box_PaddingW = new System.Windows.Forms.TextBox();
            this.Label_H = new System.Windows.Forms.Label();
            this.Label_W = new System.Windows.Forms.Label();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.pbox_prev = new System.Windows.Forms.PictureBox();
            this.TT = new System.Windows.Forms.ToolTip(this.components);
            this.HTCAPTION.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_prev)).BeginInit();
            this.SuspendLayout();
            // 
            // HTCAPTION
            // 
            this.HTCAPTION.BackColor = System.Drawing.Color.Tomato;
            this.HTCAPTION.Controls.Add(this.BtnHide);
            this.HTCAPTION.Controls.Add(this.BtnX);
            this.HTCAPTION.Location = new System.Drawing.Point(0, 0);
            this.HTCAPTION.Name = "HTCAPTION";
            this.HTCAPTION.Size = new System.Drawing.Size(640, 25);
            this.HTCAPTION.TabIndex = 0;
            // 
            // BtnHide
            // 
            this.BtnHide.BackColor = System.Drawing.Color.Transparent;
            this.BtnHide.FlatAppearance.BorderSize = 0;
            this.BtnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHide.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHide.ForeColor = System.Drawing.Color.Blue;
            this.BtnHide.Location = new System.Drawing.Point(581, -2);
            this.BtnHide.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHide.Name = "BtnHide";
            this.BtnHide.Size = new System.Drawing.Size(29, 28);
            this.BtnHide.TabIndex = 7;
            this.BtnHide.TabStop = false;
            this.BtnHide.Text = "🗕";
            this.TT.SetToolTip(this.BtnHide, "Hide to System Tray");
            this.BtnHide.UseVisualStyleBackColor = false;
            this.BtnHide.Click += new System.EventHandler(this.BtnHide_Click);
            // 
            // BtnX
            // 
            this.BtnX.BackColor = System.Drawing.Color.Transparent;
            this.BtnX.FlatAppearance.BorderSize = 0;
            this.BtnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnX.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnX.ForeColor = System.Drawing.Color.Red;
            this.BtnX.Location = new System.Drawing.Point(611, -2);
            this.BtnX.Margin = new System.Windows.Forms.Padding(0);
            this.BtnX.Name = "BtnX";
            this.BtnX.Size = new System.Drawing.Size(29, 28);
            this.BtnX.TabIndex = 6;
            this.BtnX.TabStop = false;
            this.BtnX.Text = "❌";
            this.TT.SetToolTip(this.BtnX, "Close");
            this.BtnX.UseVisualStyleBackColor = false;
            this.BtnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // PowerBtn
            // 
            this.PowerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PowerBtn.FlatAppearance.BorderSize = 0;
            this.PowerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerBtn.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerBtn.ForeColor = System.Drawing.Color.Crimson;
            this.PowerBtn.Location = new System.Drawing.Point(331, 286);
            this.PowerBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PowerBtn.Name = "PowerBtn";
            this.PowerBtn.Size = new System.Drawing.Size(300, 185);
            this.PowerBtn.TabIndex = 1;
            this.PowerBtn.Text = "❌";
            this.TT.SetToolTip(this.PowerBtn, "Start/Stop");
            this.PowerBtn.UseVisualStyleBackColor = false;
            this.PowerBtn.Click += new System.EventHandler(this.PowerBtn_Click);
            // 
            // BtnPosiLeft
            // 
            this.BtnPosiLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPosiLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPosiLeft.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnPosiLeft.Location = new System.Drawing.Point(16, 362);
            this.BtnPosiLeft.Name = "BtnPosiLeft";
            this.BtnPosiLeft.Size = new System.Drawing.Size(35, 35);
            this.BtnPosiLeft.TabIndex = 2;
            this.BtnPosiLeft.Text = "←";
            this.TT.SetToolTip(this.BtnPosiLeft, "Move Picture left by given px");
            this.BtnPosiLeft.UseVisualStyleBackColor = true;
            this.BtnPosiLeft.Click += new System.EventHandler(this.BtnPosiLeft_Click);
            // 
            // BtnPosiDown
            // 
            this.BtnPosiDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPosiDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPosiDown.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnPosiDown.Location = new System.Drawing.Point(55, 398);
            this.BtnPosiDown.Name = "BtnPosiDown";
            this.BtnPosiDown.Size = new System.Drawing.Size(35, 35);
            this.BtnPosiDown.TabIndex = 3;
            this.BtnPosiDown.Text = "↓";
            this.TT.SetToolTip(this.BtnPosiDown, "Move Picture down by given px");
            this.BtnPosiDown.UseVisualStyleBackColor = true;
            this.BtnPosiDown.Click += new System.EventHandler(this.BtnPosiDown_Click);
            // 
            // BtnPosiRight
            // 
            this.BtnPosiRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPosiRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPosiRight.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnPosiRight.Location = new System.Drawing.Point(93, 362);
            this.BtnPosiRight.Name = "BtnPosiRight";
            this.BtnPosiRight.Size = new System.Drawing.Size(35, 35);
            this.BtnPosiRight.TabIndex = 4;
            this.BtnPosiRight.Text = "→";
            this.TT.SetToolTip(this.BtnPosiRight, "Move Picture right by given px");
            this.BtnPosiRight.UseVisualStyleBackColor = true;
            this.BtnPosiRight.Click += new System.EventHandler(this.BtnPosiRight_Click);
            // 
            // BtnPosiUp
            // 
            this.BtnPosiUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPosiUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPosiUp.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnPosiUp.Location = new System.Drawing.Point(55, 328);
            this.BtnPosiUp.Name = "BtnPosiUp";
            this.BtnPosiUp.Size = new System.Drawing.Size(35, 35);
            this.BtnPosiUp.TabIndex = 5;
            this.BtnPosiUp.Text = "↑";
            this.TT.SetToolTip(this.BtnPosiUp, "Move Picture up by given px");
            this.BtnPosiUp.UseVisualStyleBackColor = true;
            this.BtnPosiUp.Click += new System.EventHandler(this.BtnPosiUp_Click);
            // 
            // TextBox_PosiSnap
            // 
            this.TextBox_PosiSnap.BackColor = System.Drawing.Color.GhostWhite;
            this.TextBox_PosiSnap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_PosiSnap.Location = new System.Drawing.Point(62, 374);
            this.TextBox_PosiSnap.MaxLength = 3;
            this.TextBox_PosiSnap.Name = "TextBox_PosiSnap";
            this.TextBox_PosiSnap.Size = new System.Drawing.Size(20, 13);
            this.TextBox_PosiSnap.TabIndex = 6;
            this.TextBox_PosiSnap.Text = "1";
            this.TextBox_PosiSnap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TT.SetToolTip(this.TextBox_PosiSnap, "Set snapping px for Picture adjustment (useful on multiple screens)");
            this.TextBox_PosiSnap.TextChanged += new System.EventHandler(this.TextBox_PosiSnap_TextChanged);
            this.TextBox_PosiSnap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_PosiSnap_KeyDown);
            // 
            // TextBox_ScrID
            // 
            this.TextBox_ScrID.BackColor = System.Drawing.Color.GhostWhite;
            this.TextBox_ScrID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_ScrID.Location = new System.Drawing.Point(253, 282);
            this.TextBox_ScrID.MaxLength = 2;
            this.TextBox_ScrID.Name = "TextBox_ScrID";
            this.TextBox_ScrID.Size = new System.Drawing.Size(15, 13);
            this.TextBox_ScrID.TabIndex = 7;
            this.TextBox_ScrID.Text = "1";
            this.TextBox_ScrID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_ScrID.TextChanged += new System.EventHandler(this.TextBox_ScrID_TextChanged);
            this.TextBox_ScrID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_ScrID_KeyDown);
            // 
            // Label_Reso
            // 
            this.Label_Reso.AutoSize = true;
            this.Label_Reso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Reso.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label_Reso.Location = new System.Drawing.Point(12, 278);
            this.Label_Reso.Name = "Label_Reso";
            this.Label_Reso.Size = new System.Drawing.Size(236, 20);
            this.Label_Reso.TabIndex = 8;
            this.Label_Reso.Text = "Inherit resolution from screen #: ";
            this.TT.SetToolTip(this.Label_Reso, "Set target Picture resolution from screen number (on multiple screens)");
            // 
            // Text_Box_PaddingH
            // 
            this.Text_Box_PaddingH.BackColor = System.Drawing.Color.GhostWhite;
            this.Text_Box_PaddingH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_Box_PaddingH.Location = new System.Drawing.Point(119, 303);
            this.Text_Box_PaddingH.MaxLength = 3;
            this.Text_Box_PaddingH.Name = "Text_Box_PaddingH";
            this.Text_Box_PaddingH.Size = new System.Drawing.Size(20, 13);
            this.Text_Box_PaddingH.TabIndex = 9;
            this.Text_Box_PaddingH.Text = "1";
            this.Text_Box_PaddingH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_Box_PaddingH.TextChanged += new System.EventHandler(this.Text_Box_PaddingH_TextChanged);
            this.Text_Box_PaddingH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_Box_PaddingH_KeyDown);
            // 
            // Label_Padding
            // 
            this.Label_Padding.AutoSize = true;
            this.Label_Padding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Padding.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label_Padding.Location = new System.Drawing.Point(12, 298);
            this.Label_Padding.Name = "Label_Padding";
            this.Label_Padding.Size = new System.Drawing.Size(101, 20);
            this.Label_Padding.TabIndex = 10;
            this.Label_Padding.Text = "Padding (px):";
            this.TT.SetToolTip(this.Label_Padding, "Set Picture padding if the (red) form background is exposed (default: 1px h/w)");
            // 
            // Text_Box_PaddingW
            // 
            this.Text_Box_PaddingW.BackColor = System.Drawing.Color.GhostWhite;
            this.Text_Box_PaddingW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_Box_PaddingW.Location = new System.Drawing.Point(163, 303);
            this.Text_Box_PaddingW.MaxLength = 3;
            this.Text_Box_PaddingW.Name = "Text_Box_PaddingW";
            this.Text_Box_PaddingW.Size = new System.Drawing.Size(20, 13);
            this.Text_Box_PaddingW.TabIndex = 11;
            this.Text_Box_PaddingW.Text = "1";
            this.Text_Box_PaddingW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_Box_PaddingW.TextChanged += new System.EventHandler(this.Text_Box_PaddingW_TextChanged);
            this.Text_Box_PaddingW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_Box_PaddingW_KeyDown);
            // 
            // Label_H
            // 
            this.Label_H.AutoSize = true;
            this.Label_H.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_H.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label_H.Location = new System.Drawing.Point(143, 303);
            this.Label_H.Name = "Label_H";
            this.Label_H.Size = new System.Drawing.Size(15, 13);
            this.Label_H.TabIndex = 12;
            this.Label_H.Text = "H";
            // 
            // Label_W
            // 
            this.Label_W.AutoSize = true;
            this.Label_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_W.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label_W.Location = new System.Drawing.Point(187, 303);
            this.Label_W.Name = "Label_W";
            this.Label_W.Size = new System.Drawing.Size(18, 13);
            this.Label_W.TabIndex = 13;
            this.Label_W.Text = "W";
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnSettings.Location = new System.Drawing.Point(16, 436);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(35, 35);
            this.BtnSettings.TabIndex = 14;
            this.BtnSettings.TabStop = false;
            this.BtnSettings.Text = "⛭";
            this.TT.SetToolTip(this.BtnSettings, "Settings");
            this.BtnSettings.UseVisualStyleBackColor = false;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // pbox_prev
            // 
            this.pbox_prev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbox_prev.BackColor = System.Drawing.Color.Black;
            this.pbox_prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbox_prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_prev.Location = new System.Drawing.Point(120, 34);
            this.pbox_prev.Name = "pbox_prev";
            this.pbox_prev.Size = new System.Drawing.Size(400, 225);
            this.pbox_prev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_prev.TabIndex = 16;
            this.pbox_prev.TabStop = false;
            this.TT.SetToolTip(this.pbox_prev, "Click to set Picture");
            this.pbox_prev.Click += new System.EventHandler(this.pbox_prev_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.pbox_prev);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.Label_W);
            this.Controls.Add(this.Label_H);
            this.Controls.Add(this.Text_Box_PaddingW);
            this.Controls.Add(this.Label_Padding);
            this.Controls.Add(this.Text_Box_PaddingH);
            this.Controls.Add(this.Label_Reso);
            this.Controls.Add(this.TextBox_ScrID);
            this.Controls.Add(this.TextBox_PosiSnap);
            this.Controls.Add(this.BtnPosiUp);
            this.Controls.Add(this.BtnPosiRight);
            this.Controls.Add(this.BtnPosiDown);
            this.Controls.Add(this.BtnPosiLeft);
            this.Controls.Add(this.PowerBtn);
            this.Controls.Add(this.HTCAPTION);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UI";
            this.Opacity = 0.95D;
            this.Text = "GifWaller";
            this.Load += new System.EventHandler(this.UI_Load);
            this.HTCAPTION.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_prev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HTCAPTION;
        private System.Windows.Forms.Button PowerBtn;
        private System.Windows.Forms.Button BtnPosiLeft;
        private System.Windows.Forms.Button BtnPosiDown;
        private System.Windows.Forms.Button BtnPosiRight;
        private System.Windows.Forms.Button BtnPosiUp;
        private System.Windows.Forms.Button BtnX;
        private System.Windows.Forms.Button BtnHide;
        private System.Windows.Forms.TextBox TextBox_PosiSnap;
        private System.Windows.Forms.TextBox TextBox_ScrID;
        private System.Windows.Forms.Label Label_Reso;
        private System.Windows.Forms.TextBox Text_Box_PaddingH;
        private System.Windows.Forms.Label Label_Padding;
        private System.Windows.Forms.TextBox Text_Box_PaddingW;
        private System.Windows.Forms.Label Label_H;
        private System.Windows.Forms.Label Label_W;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.PictureBox pbox_prev;
        private System.Windows.Forms.ToolTip TT;
    }
}

