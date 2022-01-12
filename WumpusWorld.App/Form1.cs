using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusWorld.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AIactions(object sender, EventArgs e)
        {
            AIaction.Start();
            
           
            AIaction.Stop();
        }
        void Status()
        {
            if (btn14.Text == "Breeze" && btn10.Text == "Clear")
            {
                btn15.Text = ("PIT");
            }
            if (btn9.Text == "Stench" && btn14.Text == "Breeze" && btn5.Text == "")
            {
                btn5.Text = ("Wumpus");
                btn15.Text = ("PIT");
            }
            if (btn9.Text == "Stench" && btn10.Text == "Clear" && btn5.Text == "")
            {
                btn5.Text = ("Wumpus");
            }
            if (btn2.Text == "Clear" && btn10.Text == "Clear" && btn6.Text == "Breeze\nStench\nGold")
            {
                btn7.Text = ("PIT");
            }
            if (btn5.Text == "Wumpus" && btn9.Focused || btn5.Focused)
            {
                MessageBox.Show("Wumpus bulundu ve amel defteri kapatıldı.");
                btn5.Text = ("Dead Wumpus");
            }
        }
        private void btn_Breeze(object sender, EventArgs e)
        {
            MessageBox.Show("Burada esinti var yakınlarda çukur olabilir.");

            if (btn3.Focused)
            {
                btn3.Text = ("Breeze");
            }
            if (btn8.Focused)
            {
                btn8.Text = ("Breeze");
            }
            if (btn11.Focused)
            {
                btn11.Text = ("Breeze");
            }
            if (btn14.Focused)
            {
                btn14.Text = ("Breeze");
            }
            if (btn16.Focused)
            {
                btn16.Text = ("Breeze");
            }
            Status();
        }
        private void btn_Stench(object sender, EventArgs e)
        {

            if (btn1.Focused && btn5.Text == "Dead Wumpus")
            {
                MessageBox.Show("Burada koku var ama wumpus gg");
                btn1.Text = ("Stench");
            }
            else if (btn1.Focused)
            {
                btn1.Text = ("Stench");
                MessageBox.Show("Burada koku var yakınlarda wumpus olabilir.");
            }

            if (btn9.Focused && btn5.Text == "Dead Wumpus")
            {
                MessageBox.Show("Burada koku var ama wumpus gg");
                btn9.Text = ("Stench");
            }
            else if (btn9.Focused)
            {
                btn9.Text = ("Stench");
                MessageBox.Show("Burada koku var yakınlarda wumpus olabilir.");
            }
            Status();
        }
        private void btn10_Click(object sender, EventArgs e)
        {
            if (btn2.Focused)
            {
                btn2.Text = ("Clear");
            }
            if (btn10.Focused)
            {
                btn10.Text = ("Clear");
            }
            if (btn12.Focused)
            {
                btn12.Text = ("Clear");
            }
            Status();
        }
        private void btn_Pıt(object sender, EventArgs e)
        {
            MessageBox.Show("Çukura düştünüz.");
            Application.Exit();
        }
        private void btn_Wumpus(object sender, EventArgs e)
        {
            if (btn5.Text == "")
            {
                btn5.Text = ("Wumpus");
                MessageBox.Show("Wumpusa yakalandınız.");
                Application.Exit();
            }
        }
        private void btn_Wın(object sender, EventArgs e)
        {
            btn6.Text = ("Breeze\nStench\nGold");

            Status();
            MessageBox.Show("Kazandınız.");
            Application.Exit();
        }
    }
}
