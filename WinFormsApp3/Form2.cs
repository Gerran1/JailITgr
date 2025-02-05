using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {

        public List<string> Qusts;
        public int i = 0;
        public Form2(List<string> list1)
        {

            InitializeComponent();          
            Qusts = list1;
            label1.Text = Qusts[i];
        }

        public string GetQuest(int index)
        {
            if (index >= 0 && index < Qusts.Count)
            {
                return Qusts[index];
            }
            return null;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            i++;
            label1.Text = GetQuest(i);
            if (GetQuest(i) == null)
            {
                this.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
