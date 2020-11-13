using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klientochka
{
    public partial class Form1 : Form
    {
        int role;
        public Form1(int _r)
        {
            InitializeComponent();
            role = _r;
            switch (role)
            {
                case 1:
                    button1.Visible = true;

                    break;

                case 2:
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = true;
                    button10.Visible = false;
                    button11.Visible = false;
                    button12.Visible = true;


                    break;
                default:
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vidsporta s = new Vidsporta();
            s.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Group s = new Group();
            s.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Category s = new Category();
            s.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Nagrazhdenie s = new Nagrazhdenie();
            s.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Organizator s = new Organizator();
            s.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Trener s = new Trener();
            s.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Sportsmen s = new Sportsmen();
            s.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Sorevnovanie s = new Sorevnovanie();
            s.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Sportclub s = new Sportclub();
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Nagrada s = new Nagrada();
            s.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Trenirovka s = new Trenirovka();
            s.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Typepokr s = new Typepokr();
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Typesooruzh s = new Typesooruzh();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Naznachenie s = new Naznachenie();
            s.Show();
        }
    }
}
