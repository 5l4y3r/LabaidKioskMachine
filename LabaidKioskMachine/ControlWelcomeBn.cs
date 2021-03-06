﻿using System;
using System.Windows.Forms;
using LabaidKioskMachine.Properties;

namespace LabaidKioskMachine
{
    public partial class ControlWelcomeBn : UserControl
    {
        public static int x;
        public ControlWelcomeBn()
        {
            InitializeComponent();
            x = 0;
            Dock = DockStyle.Fill;
            PanelWelcome.BackgroundImage = Resources.DocTab;
        }
        private void Complainbtn_Click(object sender, EventArgs e)
        {
            x = 1;
            this.Controls.Clear();
            ControlUserInfoBn cc = new ControlUserInfoBn(x);
            this.Controls.Add(cc);
            cc.Show();
            cc.Dock = DockStyle.Fill;
        }
        private void FeedbackBtn_Click(object sender, EventArgs e)
        {
            x = 2;
            this.Controls.Clear();
            ControlUserInfoBn cc = new ControlUserInfoBn(x);
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

        private void ControlWelcomeBn_Load(object sender, EventArgs e)
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
