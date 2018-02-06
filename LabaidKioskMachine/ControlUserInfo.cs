using System;
using System.Windows.Forms;

namespace LabaidKioskMachine
{
    public partial class ControlUserInfo : UserControl
    {
        public int p = 0;
        public ControlUserInfo(int point)
        {
            p = point;
            InitializeComponent();

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

            // BusinessLayer.UserInfoClass.AddUser(name, contact, relation);

            if (p == 1)
            {
                this.Controls.Clear();
                ControlComplain cc = new ControlComplain(name, age, contact, relation, email = txtEmail.Text);
                this.Controls.Add(cc);
                cc.Show();
                cc.Dock = DockStyle.Fill;
            }
            else if (p == 2)
            {
                this.Controls.Clear();
                ControlFeedback cc = new ControlFeedback(name, age, contact, relation, email = txtEmail.Text);
                this.Controls.Add(cc);
                cc.Show();
                cc.Dock = DockStyle.Fill;


            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ControlWelcomeBn cc = new ControlWelcomeBn();
            this.Controls.Add(cc);
            cc.Show();
            cc.Dock = DockStyle.Fill;
        }
    }
}
