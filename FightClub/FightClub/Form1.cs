using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    public partial class Form1 : Form
    {
        Player player;
        Player computer;
        private string roundString = "Round: ";
        private int round = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player = new Player("First Player");
            computer = new Player("Second Player");

            player.Block += Log;
            player.Wound += Log;
            player.Death += Log;

            computer.Block += Log;
            computer.Wound += Log;
            computer.Death += Log;

            label1.Text = player.Name;
            label2.Text = computer.Name;

            progressBar1.Value = 100;
            progressBar2.Value = 100;

            label3.Text = roundString + Convert.ToString(round);
        }

        private void Log(object sender, FightEventArgs e)
        {
            label4.Text += "a";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = false;

            if (radioButton1.Checked)
            {
                player.GetHit(BodyParts.Body);

            }
            else if (radioButton2.Checked)
            {
                player.GetHit(BodyParts.Body);
            }
            else if (radioButton3.Checked)
            {
                player.GetHit(BodyParts.Body);
            }
            else
            {
                label5.Visible = true;
            }
        }
        // как же впадлу
    }
}
