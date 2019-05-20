using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RBtn_Msg
{
    public partial class Form1 : Form
    {
        private MessageBoxButtons mbb;
        private MessageBoxIcon mbi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                this.mbb = MessageBoxButtons.OK;
            }
            else if (this.radioButton2.Checked)
            {
                this.mbb = MessageBoxButtons.OKCancel;
            }
            else if(this.radioButton3.Checked)
            {
                this.mbb = MessageBoxButtons.YesNo;
            }

            if (this.radioButton4.Checked)
            {
                this.mbi = MessageBoxIcon.Error;
            }
            else if (this.radioButton5.Checked)
            {
                this.mbi = MessageBoxIcon.Information;
            }
            else
            {
                this.mbi = MessageBoxIcon.Question;
            }

            MessageBox.Show("메세지 박스를 확인하세요", "알림", mbb, mbi);
        }
    }
}
