namespace GifWaller
{
    public partial class UI
    {

        internal System.Windows.Forms.Button BtnLoad = new System.Windows.Forms.Button();
        private System.Windows.Forms.Button BtnSave = new System.Windows.Forms.Button();
        private System.Windows.Forms.Panel HTCAPTION_Settings;
        private System.Windows.Forms.Button BtnXsettings;
        private System.Windows.Forms.Button BtnDefaults;
        private System.Windows.Forms.LinkLabel Link_Author_Sayan;

        this.HTCAPTION_Settings = new System.Windows.Forms.Panel();
        this.BtnDefaults = new System.Windows.Forms.Button();
        this.BtnXsettings = new System.Windows.Forms.Button();
        this.Link_Author_Sayan = new System.Windows.Forms.LinkLabel();
        this.HTCAPTION_Settings.SuspendLayout();

        BtnLoad.BackColor = System.Drawing.Color.Transparent;
        this.BtnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.BtnLoad.ForeColor = System.Drawing.Color.OrangeRed;
        this.BtnLoad.Location = new System.Drawing.Point(12, 26);
        this.BtnLoad.Name = "BtnLoad";
        this.BtnLoad.Size = new System.Drawing.Size(75, 23);
        this.BtnLoad.TabIndex = 0;
        this.BtnLoad.TabStop = false;
        this.BtnLoad.Text = "Save";
        this.BtnLoad.UseVisualStyleBackColor = false;
        this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);


        this.BtnSave.BackColor = System.Drawing.Color.Transparent;
        this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.BtnSave.ForeColor = System.Drawing.Color.OrangeRed;
        this.BtnSave.Location = new System.Drawing.Point(98, 26);
        this.BtnSave.Name = "BtnSave";
        this.BtnSave.Size = new System.Drawing.Size(75, 23);
        this.BtnSave.TabIndex = 1;
        this.BtnSave.TabStop = false;
        this.BtnSave.Text = "Load";
        this.BtnSave.UseVisualStyleBackColor = false;
        this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);


        this.HTCAPTION_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
        this.HTCAPTION_Settings.BackColor = System.Drawing.Color.Tomato;
        this.HTCAPTION_Settings.Controls.Add(this.BtnDefaults);
        this.HTCAPTION_Settings.Controls.Add(this.BtnX);
        this.HTCAPTION_Settings.Location = new System.Drawing.Point(0, 0);
        this.HTCAPTION_Settings.Name = "HTCAPTION_Settings";
        this.HTCAPTION_Settings.Size = new System.Drawing.Size(185, 20);
        this.HTCAPTION_Settings.TabIndex = 2;


        this.BtnDefaults.BackColor = System.Drawing.Color.Transparent;
        this.BtnDefaults.FlatAppearance.BorderSize = 0;
        this.BtnDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.BtnDefaults.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.BtnDefaults.ForeColor = System.Drawing.Color.Black;
        this.BtnDefaults.Location = new System.Drawing.Point(0, -4);
        this.BtnDefaults.Margin = new System.Windows.Forms.Padding(0);
        this.BtnDefaults.Name = "BtnDefaults";
        this.BtnDefaults.Size = new System.Drawing.Size(65, 25);
        this.BtnDefaults.TabIndex = 8;
        this.BtnDefaults.TabStop = false;
        this.BtnDefaults.Text = "Defaults";
        this.BtnDefaults.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.BtnDefaults.UseVisualStyleBackColor = false;
        this.BtnDefaults.Click += new System.EventHandler(this.BtnDefaults_Click);


        this.BtnXsettings.BackColor = System.Drawing.Color.Transparent;
        this.BtnXsettings.FlatAppearance.BorderSize = 0;
        this.BtBtnXsettingsnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.BtnXsettings.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.BtnXsettings.ForeColor = System.Drawing.Color.Red;
        this.BtnXsettings.Location = new System.Drawing.Point(157, -3);
        this.BtnXsettings.Margin = new System.Windows.Forms.Padding(0);
        this.BtnXsettings.Name = "BtnX";
        this.BtnXsettings.Size = new System.Drawing.Size(30, 25);
        this.BtnXsettings.TabIndex = 7;
        this.BtnXsettings.TabStop = false;
        this.BtnXsettings.Text = "❌";
        this.BtnXsettings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        this.BtnXsettings.UseVisualStyleBackColor = false;
        this.BtnX.Click += new System.EventHandler(this.BtnX_Click);


        this.Link_Author_Sayan.ActiveLinkColor = System.Drawing.Color.Blue;
        this.Link_Author_Sayan.AutoSize = true;
        this.Link_Author_Sayan.LinkColor = System.Drawing.Color.RoyalBlue;
        this.Link_Author_Sayan.Location = new System.Drawing.Point(13, 52);
        this.Link_Author_Sayan.Name = "Link_Author_Sayan";
        this.Link_Author_Sayan.Size = new System.Drawing.Size(164, 13);
        this.Link_Author_Sayan.TabIndex = 3;
        this.Link_Author_Sayan.TabStop = true;
        this.Link_Author_Sayan.Text = "GitHub.com/Sayan505/GifWaller";
        this.Link_Author_Sayan.VisitedLinkColor = System.Drawing.Color.Blue;
        this.Link_Author_Sayan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Author_Sayan_LinkClicked);
 

        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        this.ClientSize = new System.Drawing.Size(185, 70);
        this.Controls.Add(this.Link_Author_Sayan);
        this.Controls.Add(this.HTCAPTION_Settings);
        this.Controls.Add(this.BtnSave);
        this.Controls.Add(this.BtnLoad);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "Settings";
        this.Text = "Settings";
        this.HTCAPTION_Settings.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();



    }
}