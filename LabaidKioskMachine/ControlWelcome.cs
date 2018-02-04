using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaidKioskMachine
{
    public partial class ControlWelcome : UserControl
    {
        public static int x;
        public ControlWelcome()
        {
            InitializeComponent();
            x = 0;
            Dock = DockStyle.Fill;

        }

        private void Complainbtn_Click(object sender, EventArgs e)
        {
            x = 1;
            this.Controls.Clear();
            ControlUserInfo cc = new ControlUserInfo(x);
            this.Controls.Add(cc);
            cc.Show();
            cc.Dock = DockStyle.Fill;
        }
        private void FeedbackBtn_Click(object sender, EventArgs e)
        {
            x = 2;

            this.Controls.Clear();
            ControlUserInfo cc = new ControlUserInfo(x);
            this.Controls.Add(cc);
            cc.Show();
            cc.Dock = DockStyle.Fill;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ControlLanguage cc = new ControlLanguage();
            this.Controls.Add(cc);
            cc.Show();
            cc.Dock = DockStyle.Fill;
        }
    }
}
