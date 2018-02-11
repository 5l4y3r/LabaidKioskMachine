using System;
using System.Text.RegularExpressions;
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
        public ControlUserInfo(int pointz, string name,int age,string contact,string relation, string email)
        {
            p = pointz;
            InitializeComponent();
            txtAge.Text = Convert.ToString(age);
            txtName.Text = name;
            txtContact.Text = contact;
            txtEmail.Text= email;
            if (relation == "Patient")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }

        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            int tempmbl = 0, tempName = 0, tempage = 0, tempUpdate=0;
            string name, contact, relation, email;
            var regex = new Regex(@"^\d{2}$");
            string age = txtAge.Text;
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

            if (regexName.IsMatch(name))
            {
                tempName = 1;
            }
            else
            {

                MessageBox.Show("please correct the name");
            }

            if (regexMobile.IsMatch(contact))
            {
                tempmbl = 1;
            }
            else
            {

                MessageBox.Show("Incorrect Mobile No");
            }

            if (!regex.IsMatch(txtAge.Text))
            {
                
                MessageBox.Show("Age should be <100!");
            }
            else
            {
                tempage = 1;
            }
            if (tempName == 1 && tempmbl == 1 && tempage == 1)
            {
                tempUpdate = 0;
            }
            else
            {
                tempUpdate = 1;
            }

            if (p == 1 && tempUpdate == 0)
            {
                this.Controls.Clear();
                ControlComplain cc = new ControlComplain(name, Convert.ToInt32(age), contact, relation, email = txtEmail.Text);
                this.Controls.Add(cc);
                cc.Show();
                cc.Dock = DockStyle.Fill;
            }
            else if (p == 2 && tempUpdate == 0)
            {
                this.Controls.Clear();
                ControlFeedback cc = new ControlFeedback(name, Convert.ToInt32(age), contact, relation, email = txtEmail.Text);
                this.Controls.Add(cc);
                cc.Show();
                cc.Dock = DockStyle.Fill;


            }
        }

        public  Regex regexName = new Regex(
      "(^[A-Za-z ]*$)",
    RegexOptions.IgnoreCase
    | RegexOptions.CultureInvariant
    | RegexOptions.IgnorePatternWhitespace
    | RegexOptions.Compiled
    );

        public  Regex regexMobile = new Regex(
            "(^[0-9]{11}$)|(^\\+[0-9]{13}$)|(^[0-9]{13}$)",
            RegexOptions.IgnoreCase
            | RegexOptions.CultureInvariant
            | RegexOptions.IgnorePatternWhitespace
            | RegexOptions.Compiled
            );

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
