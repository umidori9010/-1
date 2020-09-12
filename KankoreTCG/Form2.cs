using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace test1
{
    
    public partial class Form2 : Form
    {
        public int opn = 0;
        public int i = 0,j=525;

        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("体験版ではデッキの編集はできません。");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (opn == 0)
            {
                Form1 frm = new Form1();
                frm.Owner = this;
                frm.Show();
                opn = 1;
                frm.StartConfig();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("戦闘中は操作できません。");
            }
            //this.Close();
        }
        public void fm1end()
        {
            opn = 0;
        }
        public void button3_Click(object sender, EventArgs e)
        {
            int trigger = Environment.TickCount;
            int tim;
           for (tim = 0; tim<= 5000;)
            {
                //System.Threading.Thread.Sleep(1000);
                tim = Environment.TickCount - trigger;
            }
            MessageBox.Show("end");
        }
    }
}
