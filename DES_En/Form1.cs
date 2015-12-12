using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DES_En;

namespace DES_En
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DES en = new DES();
            en.InputStr = textBox_M.Text;
            en.Key = textBox_Key.Text;
            en.Encrypt();
            textBox_C.Text = en.OutputStr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DES de = new DES();
            de.InputStr = textBox_C.Text;
            de.Key = textBox_Key.Text;
            de.Decrypt();
            textBox_CM.Text = de.OutputStr;
        }
    }
}
