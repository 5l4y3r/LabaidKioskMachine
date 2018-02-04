using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabaidKioskMachine.Properties;

namespace LabaidKioskMachine
{
    public partial class ControlLanguage : UserControl
    {
        public ControlLanguage()
        {
            InitializeComponent();
            
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            ControlWelcome cc = new ControlWelcome();
            this.Controls.Add(cc);
            cc.Show();
            cc.Dock = DockStyle.Fill;
        }

        private void btnBangla_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            ControlWelcomeBn cc = new ControlWelcomeBn();
            this.Controls.Add(cc);
            cc.Show();
            cc.Dock = DockStyle.Fill;

        }
    }
}
