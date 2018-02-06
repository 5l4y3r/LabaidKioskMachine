using System;
using System.Windows.Forms;
using LabaidKioskMachine.Properties;

namespace LabaidKioskMachine
{
    public partial class ControlLanguage : UserControl
    {
        public ControlLanguage()
        {
            InitializeComponent();
            tlp1.BackgroundImage = Resources.DocTab;

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

        private void tlp1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ControlLanguage_Load(object sender, EventArgs e)
        {
    
                    

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
    }
}
