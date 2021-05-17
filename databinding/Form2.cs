using System;
using System.Windows.Forms;

namespace DataBinding
{

    public partial class Form2 : Form
    {
        static public string text;
        public Form2()
        {
            InitializeComponent();
        }
        Form1 f = new Form1();
        

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
