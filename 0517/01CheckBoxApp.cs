﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateLabel(string s, bool b)
        {
            if (b)
            {
                label1.Text += s; // label1의 Text 프로퍼티에 문자열 추가
            }
            else
            {
                string strTemp = label1.Text;
                int i = strTemp.IndexOf(s);
                label1.Text = strTemp.Remove(i, s.Length);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox3.Text, checkBox3.Checked);

        }

        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox2.Text, checkBox2.Checked);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox1.Text, checkBox1.Checked);
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {

            UpdateLabel(checkBox4.Text, checkBox4.Checked);
        }
    }
}
