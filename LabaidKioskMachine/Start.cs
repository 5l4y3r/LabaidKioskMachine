using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaidKioskMachine
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
        }
      
        private void Start_Load(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            ControlLanguage cc = new ControlLanguage();
            panelMain.Controls.Add(cc);
            cc.Show();
            cc.Dock = DockStyle.Fill;
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
