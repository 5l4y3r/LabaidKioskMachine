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
    public partial class ControlUserInfoBn : UserControl
    {
        public int p = 0;
        public ControlUserInfoBn(int point)
        {
            InitializeComponent();
            p = point;
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            string name, contact, relation, email;
            int age = Convert.ToInt32(txtAge.Text);
            name = txtName.Text;
            contact = txtContact.Text;
            email = txtEmail.Text;
            if (radioButton1.Checked)
            {
                relation = "Patient";
            }
            else
            {
                relation = "patient's relative";
            }

           
            if (p == 1)
            {
                this.Controls.Clear();
                ControlComplainBn cc = new ControlComplainBn(name, age, contact, relation, email = txtEmail.Text);
                this.Controls.Add(cc);
                cc.Show();
                cc.Dock = DockStyle.Fill;
            }
            else if (p == 2)
            {
                this.Controls.Clear();
                ControlFeedbackBn cc = new ControlFeedbackBn(name, age, contact, relation, email = txtEmail.Text);
                this.Controls.Add(cc);
                cc.Show();
                cc.Dock = DockStyle.Fill;


            }
        }
    }
}
