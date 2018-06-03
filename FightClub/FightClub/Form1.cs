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
        string[] logString = { "" };

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

            label3.Text = roundString + Convert.ToString(round);
        }

        private void Log(object sender, FightEventArgs e)
        {
            if (player.HP <= 0)
            {
                logString[0] = player.Name + " was won!";
            }
            else if (computer.HP <= 0)
            {
                logString[0] = computer.Name + " was won!";
            }
            else
            {
                logString[0] = roundString + Convert.ToString(round) + " " + e.Name + " " + e.HP + "\n";
            }
            listBox1.Items.AddRange(logString);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            // if hp > 0
                // if что-то выбрано
                // ++ раунд
                // смотря какой раунд
                // if нападаем()
                // else защищаемя()
            // else начать заново

            if (player.HP > 0 && computer.HP > 0)
            {
                if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
                {
                    round++;

                    if (round % 2 == 1)
                    {
                        Hit();
                    }
                    else
                    {
                        Block();
                    }

                    progressBar1.Value = player.HP;
                    progressBar2.Value = computer.HP;
                }
                else
                {
                    label5.Visible = true;
                }
            }
            else
            {

            }
        }

        private BodyParts RandomBodyPart()
        {
            Random random = new Random();
            int bodyPart = random.Next(0, 2);
            return (BodyParts)bodyPart;
        }

        private void Hit()
        {
            button1.Text = "Block";
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
        }

        private void Block()
        {
            button1.Text = "Hit";
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

            player.GetHit(RandomBodyPart());
        }
    }
}
