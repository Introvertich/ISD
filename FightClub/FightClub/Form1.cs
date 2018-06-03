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

            computer.SetBlock(RandomBodyPart());
        }

        private void Log(object sender, FightEventArgs e)
        {
            string[] s = { roundString + Convert.ToString(round) + " " + e.Name + " " + e.HP + "\n" };
            listBox1.Items.AddRange(s);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            round++;

            if (round % 2 == 1)
            {
                button1.Text = "Hit";
                label5.Visible = false;

                computer.SetBlock(RandomBodyPart());

                if (radioButton1.Checked)
                {
                    computer.GetHit(BodyParts.Head);

                }
                else if (radioButton2.Checked)
                {
                    computer.GetHit(BodyParts.Body);
                }
                else if (radioButton3.Checked)
                {
                    computer.GetHit(BodyParts.Legs);
                }
                else
                {
                    label5.Visible = true;
                }

            }
            else
            {
                button1.Text = "Block";
                label5.Visible = false;
                
                if (radioButton1.Checked)
                {
                    player.SetBlock(BodyParts.Head);

                }
                else if (radioButton2.Checked)
                {
                    player.SetBlock(BodyParts.Body);
                }
                else if (radioButton3.Checked)
                {
                    player.SetBlock(BodyParts.Legs);
                }
                else
                {
                    label5.Visible = true;
                }

                player.GetHit(RandomBodyPart());
            }

            progressBar1.Value = player.HP;
            progressBar2.Value = computer.HP;

            if (player.HP <= 0)
            {
                string[] s = { computer.Name + " was won!" };
                listBox1.Items.AddRange(s);
            }
            else if (computer.HP <= 0)
            {
                string[] s = { player.Name + " was won!" };
                listBox1.Items.AddRange(s);
            }
        }

        private BodyParts RandomBodyPart()
        {
            Random random = new Random();
            int bodyPart = random.Next(0, 2);
            return (BodyParts)bodyPart;
        }
    }
}
