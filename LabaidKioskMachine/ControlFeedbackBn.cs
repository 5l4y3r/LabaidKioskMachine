using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using ns1;

namespace LabaidKioskMachine
{
    public partial class ControlFeedbackBn : UserControl
    {
        static int x = 0;


        public static List<Label> QLabels = new List<Label>();
        public List<string> feedbkList = new List<string>();
        public List<Label> QLabelEx = new List<Label>();
        public List<BunifuRating> QStars = new List<BunifuRating>();

        static string uName = "";
        static int uAge = 0;
        static string uRelation = "";
        static string uContact = "";
        static string uEmail = "";


        public ControlFeedbackBn(string s1, int s2, string s3, string s4, string s5)
        {
            InitializeComponent();
            uName = s1;
            uAge = s2;
            uRelation = s4;
            uContact = s3;
            uEmail = s5;
            bunifuiOSSwitch1.Value = false;
            AddingLabelInList();
            VisibilityControl();


        }

        private void FeedbackSubmitBtn_Click(object sender, EventArgs e)
        {
            NextPhase();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ControlWelcomeBn cc = new ControlWelcomeBn();
            this.Controls.Add(cc);
            cc.Show();
            cc.Dock = DockStyle.Fill;
        }

        private void VisibilityControl()
        {

            labelEx1.Visible = false;
            labelEx2.Visible = false;
            labelEx3.Visible = false;
            labelEx4.Visible = false;
            labelEx5.Visible = false;
            labelEx6.Visible = false;
            labelEx7.Visible = false;
            labelEx8.Visible = false;
            labelEx9.Visible = false;
            labelEx10.Visible = false;
            labelEx11.Visible = false;
            labelEx12.Visible = false;
            labelEx13.Visible = false;
            labelEx14.Visible = false;
            labelEx15.Visible = false;
            labelEx16.Visible = false;
            labelEx17.Visible = false;
            labelEx18.Visible = false;

        }

        private void AddingLabelInList()
        {
            QLabels.Add(labelQuestion1);
            QLabels.Add(labelQuestion2);
            QLabels.Add(labelQuestion3);
            QLabels.Add(labelQuestion4);
            QLabels.Add(labelQuestion5);
            QLabels.Add(labelQuestion6);
            QLabels.Add(labelQuestion7);
            QLabels.Add(labelQuestion8);
            QLabels.Add(labelQuestion9);
            QLabels.Add(labelQuestion10);
            QLabels.Add(labelQuestion11);
            QLabels.Add(labelQuestion12);
            QLabels.Add(labelQuestion13);
            QLabels.Add(labelQuestion14);
            QLabels.Add(labelQuestion15);
            QLabels.Add(labelQuestion16);
            QLabels.Add(labelQuestion17);
            QLabels.Add(labelQuestion18);

            QStars.Add(RatingQ1);
            QStars.Add(RatingQ2);
            QStars.Add(RatingQ3);
            QStars.Add(RatingQ4);
            QStars.Add(RatingQ5);
            QStars.Add(RatingQ6);
            QStars.Add(RatingQ7);
            QStars.Add(RatingQ8);
            QStars.Add(RatingQ9);
            QStars.Add(RatingQ10);
            QStars.Add(RatingQ11);
            QStars.Add(RatingQ12);
            QStars.Add(RatingQ13);
            QStars.Add(RatingQ14);
            QStars.Add(RatingQ15);
            QStars.Add(RatingQ16);
            QStars.Add(RatingQ17);
            QStars.Add(RatingQ18);


            QLabelEx.Add(labelEx1);
            QLabelEx.Add(labelEx2);
            QLabelEx.Add(labelEx3);
            QLabelEx.Add(labelEx4);
            QLabelEx.Add(labelEx5);
            QLabelEx.Add(labelEx6);
            QLabelEx.Add(labelEx7);
            QLabelEx.Add(labelEx8);
            QLabelEx.Add(labelEx9);
            QLabelEx.Add(labelEx10);
            QLabelEx.Add(labelEx11);
            QLabelEx.Add(labelEx12);
            QLabelEx.Add(labelEx13);
            QLabelEx.Add(labelEx14);
            QLabelEx.Add(labelEx15);
            QLabelEx.Add(labelEx16);
            QLabelEx.Add(labelEx17);
            QLabelEx.Add(labelEx18);

        }

        private void NextPhase()
        {
            if (RatingQ1.Value > 0 && RatingQ2.Value > 0 && RatingQ3.Value > 0 && RatingQ4.Value > 0 &&
                RatingQ5.Value > 0 && RatingQ6.Value > 0 && RatingQ7.Value > 0 && RatingQ8.Value > 0 &&
                RatingQ9.Value > 0 && RatingQ10.Value > 0 && RatingQ11.Value > 0 && RatingQ12.Value > 0 &&
                RatingQ13.Value > 0 && RatingQ14.Value > 0 && RatingQ15.Value > 0 && RatingQ16.Value > 0 &&
                RatingQ17.Value > 0 && RatingQ18.Value > 0)
            {
                MessageBox.Show("Thank You For your time sir!");
                TxtGenarator();
                backgroundWorker1.RunWorkerAsync();
                this.Controls.Clear();

                ControlWelcomeBn cc = new ControlWelcomeBn();
                this.Controls.Add(cc);
                cc.Show();
                cc.Dock = DockStyle.Fill;

            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("You are missing something!! Still want to submit?", "Missing review", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TxtGenarator();
                    backgroundWorker1.RunWorkerAsync();
                    this.Controls.Clear();

                    ControlWelcomeBn cc = new ControlWelcomeBn();
                    this.Controls.Add(cc);
                    cc.Show();
                    cc.Dock = DockStyle.Fill;
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }



        }

        private string rateText(int value)
        {
            if (value == 0)
            {
                return "No feedback";
            }
            else if (value == 1)
            {
                return "Poor";
            }
            else if (value == 2)
            {

                return "Below Average";
            }
            else if (value == 3)
            {
                return "Average";
            }
            else if (value == 4)
            {
                return "Above Average";
            }
            else if (value == 5)
            {
                return "Excellent";
            }
            return " ";
        }

        private void RatingQ1_onValueChanged(object sender, EventArgs e)
        {
            labelEx1.Text = rateText(RatingQ1.Value);
            labelEx1.Visible = true;

        }

        private void RatingQ2_onValueChanged(object sender, EventArgs e)
        {
            labelEx2.Text = rateText(RatingQ2.Value);
            labelEx2.Visible = true;
        }

        private void RatingQ3_onValueChanged(object sender, EventArgs e)
        {
            labelEx3.Text = rateText(RatingQ3.Value);
            labelEx3.Visible = true;
        }

        private void RatingQ4_onValueChanged(object sender, EventArgs e)
        {
            labelEx4.Text = rateText(RatingQ4.Value);
            labelEx4.Visible = true;

        }
        private void RatingQ5_onValueChanged(object sender, EventArgs e)
        {
            labelEx5.Text = rateText(RatingQ5.Value);
            labelEx5.Visible = true;
        }

        private void RatingQ6_onValueChanged(object sender, EventArgs e)
        {
            labelEx6.Text = rateText(RatingQ6.Value);
            labelEx6.Visible = true;
        }

        private void RatingQ7_onValueChanged(object sender, EventArgs e)
        {
            labelEx7.Text = rateText(RatingQ7.Value);
            labelEx7.Visible = true;
        }

        private void RatingQ8_onValueChanged(object sender, EventArgs e)
        {
            labelEx8.Text = rateText(RatingQ8.Value);
            labelEx8.Visible = true;
        }

        private void RatingQ9_onValueChanged(object sender, EventArgs e)
        {
            labelEx9.Text = rateText(RatingQ9.Value);
            labelEx9.Visible = true;
        }

        private void RatingQ10_onValueChanged(object sender, EventArgs e)
        {
            labelEx10.Text = rateText(RatingQ10.Value);
            labelEx10.Visible = true;
        }

        private void RatingQ11_onValueChanged(object sender, EventArgs e)
        {
            labelEx11.Text = rateText(RatingQ11.Value);
            labelEx11.Visible = true;
        }

        private void RatingQ12_onValueChanged(object sender, EventArgs e)
        {
            labelEx12.Text = rateText(RatingQ12.Value);
            labelEx12.Visible = true;
        }

        private void RatingQ13_onValueChanged(object sender, EventArgs e)
        {
            labelEx13.Text = rateText(RatingQ13.Value);
            labelEx13.Visible = true;
        }

        private void RatingQ14_onValueChanged(object sender, EventArgs e)
        {
            labelEx14.Text = rateText(RatingQ14.Value);
            labelEx14.Visible = true;
        }

        private void RatingQ15_onValueChanged(object sender, EventArgs e)
        {
            labelEx15.Text = rateText(RatingQ15.Value);
            labelEx15.Visible = true;
        }

        private void RatingQ16_onValueChanged(object sender, EventArgs e)
        {
            labelEx16.Text = rateText(RatingQ16.Value);
            labelEx16.Visible = true;
        }

        private void RatingQ17_onValueChanged(object sender, EventArgs e)
        {
            labelEx17.Text = rateText(RatingQ17.Value);
            labelEx17.Visible = true;
        }

        private void RatingQ18_onValueChanged(object sender, EventArgs e)
        {
            labelEx18.Text = rateText(RatingQ18.Value);
            labelEx18.Visible = true;

        }

        void TxtGenarator()
        {
            if (File.Exists("Feedback.txt"))
            {
                File.Delete("Feedback.txt");

            }

            using (FileStream file = new FileStream("Feedback.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read))
            using (StreamWriter writer = new StreamWriter(file, Encoding.Unicode))
            {
                writer.WriteLine("This is a feedback document.\t\t" + DateTime.Now);
                writer.WriteLine(" ");
                writer.WriteLine(" ");
                writer.WriteLine("Name:" + uName + "\t\t" + "Relation:" + uRelation);
                writer.WriteLine("Age: " + uAge + "\t\t" + "Contact No: " + uContact + "\t\tEmail: " + uEmail);
                writer.WriteLine(" ");
                writer.WriteLine(" ");
                writer.WriteLine(" ");

                for (int i = 0; i < 18; i++)
                {
                    writer.WriteLine(QLabels[i].Text + " = " + QLabelEx[i].Text);
                }
            }


        }

        void sendMail()
        {

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("labaidkiosk@gmail.com");
            mail.To.Add("golisr@labaidgroup.com");
            mail.Subject = "New Feedback";
            mail.Body = "New feedback is in the file";

            Attachment attachment;
            attachment = new System.Net.Mail.Attachment(@"Feedback.txt");
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

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value)
            {

                this.Controls.Clear();
                ControlFeedback cc = new ControlFeedback(uName, uAge, uRelation, uContact, uEmail);
                this.Controls.Add(cc);
                cc.Show();
                cc.Dock = DockStyle.Fill;

            }
        }
    }
}
