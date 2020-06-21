using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GifWaller
{
    public partial class Settings : Form
    {
        /*          SETTINGS            */
        //image posi
        internal int CurrPosiX = 0;
        internal int CurrPosiY = 0;

        //image padding (generally, 1px required)
        //A red outline (form background) might show up on weird resolutions. That's when you need to configure padding.
        internal byte PadH = 1;
        internal byte PadW = 1;

        //image move snapping
        internal byte Snapf = 1;

        //image reso
        internal byte ScrID = 1;

        //gif path
        internal string file = string.Empty;
        /*          SETTINGS            */


        /*          DEFAULTS            */
        //image posi
        private int DefCurrPosiX = 0;
        private int DefCurrPosiY = 0;

        //image padding (generally, 1px required)
        //A red outline (form background) might show up on weird resolutions. That's when you need to configure padding.
        private byte DefPadH = 1;
        private byte DefPadW = 1;

        //image move snapping
        private byte DefsSapf = 1;

        //image reso
        private byte DefScrID = 1;

        //gif path
        internal string DefFile = string.Empty;
        /*          DEFAULTS            */

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
            using (BinaryWriter BW = new BinaryWriter(File.Open(@"settings", FileMode.Create)))
            {
                //
            }
        }
    }
}
