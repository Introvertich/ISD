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
        private Player player;
        private Player computer;
        private const string roundString = "Round: ";
        private const string buttonHit = "Hit";
        private const string buttonBlock = "Block";
        private int round = 1;
        private string[] logString = { "" };
        private Form2 form2;

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

            label4.Text = Convert.ToString(player.HP);
            label6.Text = Convert.ToString(computer.HP);

            label3.Text = roundString + Convert.ToString(round);
        }

        private void Log(object sender, FightEventArgs e)
        {
            logString[0] = roundString + Convert.ToString(round) + " " + e.Name + " " + e.HP + " HP";
            listBox1.Items.AddRange(logString);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                if (button1.Text == buttonHit)
                {
                    Hit();
                }
                else
                {
                    Block();
                }
                CheckGameOver();
                UpdateInterface();
            }
            else
            {
                label5.Visible = true;
            }
        }

        private BodyParts RandomBodyPart()
        {
            Random random = new Random();
            int bodyPart = random.Next(0, 2);
            return (BodyParts)bodyPart;
        }
        
        private BodyParts ReturnCheckBox()
        {
            if (radioButton1.Checked)
            {
                return BodyParts.Head;

            }
            else if (radioButton2.Checked)
            {
                return BodyParts.Body;
            }
            else
            {
                return BodyParts.Legs;
            }
        }

        private void Hit()
        {
            computer.SetBlock(RandomBodyPart());

            computer.GetHit(ReturnCheckBox());

        }

        private void Block()
        {
            player.SetBlock(ReturnCheckBox());
            player.GetHit(RandomBodyPart());
        }

        private void UpdateInterface()
        {
            if (button1.Text == buttonBlock)
            {
                round++;
                button1.Text = buttonHit;
            }
            else
            {
                button1.Text = buttonBlock;
            }
            label3.Text = roundString + Convert.ToString(round);
            progressBar1.Value = player.HP;
            progressBar2.Value = computer.HP;
            label4.Text = Convert.ToString(player.HP);
            label6.Text = Convert.ToString(computer.HP);
            label5.Visible = false;
        }

        private void CheckGameOver()
        {
            if (player.HP <= 0)
            {
                form2 = new Form2(computer.Name + " was won!");
                form2.Show();
            }
            else if (computer.HP <= 0)
            {
                form2 = new Form2(player.Name + " was won!");
                form2.Show();
            }
        }
    }
}
