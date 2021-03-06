﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;

using System.Windows.Forms;

namespace LabaidKioskMachine
{
    public partial class ControlComplainBn : UserControl
    {
        static int x;
        static string uName = "";
        static int uAge = 0;
        static string uRelation = "";
        static string uContact = "";
        static string uEmail = "";
        List<string> complainLst = new List<string>();

        public ControlComplainBn(string s1, int s2, string s3, string s4, string s5)
        {
            InitializeComponent();
            bunifuiOSSwitch1.Value = false;
            uName = s1;
            uAge = s2;
            uRelation = s4;
            uContact = s3;
            uEmail = s5;
            x = 0;
        }
        public ControlComplainBn(string[] arr, string s1, int s2, string s3, string s4, string s5)
        {
            InitializeComponent();
            txtDoc.Text = arr[0];
            txtNurse.Text = arr[1];
            txtAcco.Text = arr[2];
            txtHelp.Text = arr[3];
            txtBilling.Text = arr[4];
            uName = s1;
            uAge = s2;
            uRelation = s4;
            uContact = s3;
            uEmail = s5;
            x = 0;
           
        }
        private void ComplainSubmitBtn_Click(object sender, EventArgs e)
        {
            string s1 = " ", s2 = " ", s3 = " ", s4 = " ", s5 = " ", s11, s22, s33, s44, s55;
            s1 = txtDoc.Text;
            s2 = txtNurse.Text;
            s3 = txtAcco.Text;
            s4 = txtHelp.Text;
            s5 = txtBilling.Text;
            s11 = "Doctor";
            s22 = "Nurse";
            s33 = "Accommodation";
            s44 = "Help Desk";
            s55 = "Billing";

            complainLst.Add(s11 + " : " + s1);
            complainLst.Add(s22 + " : " + s2);
            complainLst.Add(s33 + " : " + s3);
            complainLst.Add(s44 + " : " + s4);
            complainLst.Add(s55 + " : " + s5);
            TxtGenarator();
            backgroundWorker1.RunWorkerAsync();
            MessageBox.Show("আমরা অতি শিগ্রই সমস্যাটি সমাধান এর চেষ্টা করবো.. ধন্যবাদ ।");

            this.Controls.Clear();
            ControlWelcomeBn cc = new ControlWelcomeBn();
            this.Controls.Add(cc);
            cc.Show();
            cc.Dock = DockStyle.Fill;
        }

        void TxtGenarator()
        {
            if (File.Exists("Complain.txt"))
            {
                File.Delete("Complain.txt");

            }

            using (FileStream file = new FileStream("Complain.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read))
            using (StreamWriter writer = new StreamWriter(file, Encoding.Unicode))
            {
                writer.WriteLine("This is a Complain document.\t\t" + DateTime.Now);
                writer.WriteLine(" ");
                writer.WriteLine(" ");
                writer.WriteLine("Name:" + uName + "\t\t" + "Relation:" + uRelation);
                writer.WriteLine("Age: " + uAge + "\t\t" + "Contact No: " + uContact + "\t\tEmail: " + uEmail);

                writer.WriteLine(" ");
                writer.WriteLine(" ");
                writer.WriteLine(" ");
                foreach (var s in complainLst)
                {
                    writer.WriteLine(s);
                }
            }


        }

        void sendMail()
        {

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("labaidkiosk@gmail.com");
            mail.To.Add("golisr@labaidgroup.com");
            mail.Subject = "New Complain";
            mail.Body = "Here's your complain in the file";

            Attachment attachment;
            attachment = new System.Net.Mail.Attachment(@"Complain.txt");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("labaidkiosk@gmail.com", "kiosk1234");
            SmtpServer.EnableSsl = true;

            try
            {
                // IPHostEntry dummy = Dns.GetHostEntry("https://www.google.com");
                SmtpServer.Send(mail);

            }
            catch (SocketException ex)
            {
                MessageBox.Show("No internet connection");

            }
            mail.Dispose();


        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            sendMail();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ControlWelcomeBn cc = new ControlWelcomeBn();
            this.Controls.Add(cc);
            cc.Show();
            cc.Dock = DockStyle.Fill;

        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value)
            {
                string[] arr = new string[5];

                arr[0] = txtDoc.Text;
                arr[1] = txtNurse.Text;
                arr[2] = txtAcco.Text;
                arr[3] = txtHelp.Text;
                arr[4] = txtBilling.Text;
                 this.Controls.Clear();

                ControlComplain cc = new ControlComplain(arr,uName, uAge, uRelation, uContact, uEmail);
                this.Controls.Add(cc);
                cc.Show();
                cc.Dock = DockStyle.Fill;

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ControlUserInfoBn cc = new ControlUserInfoBn(1, uName, uAge, uContact, uRelation, uEmail);
            this.Controls.Add(cc);
            cc.Show();
            cc.Dock = DockStyle.Fill;
        }
    }
}
