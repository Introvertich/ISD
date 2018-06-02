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
        private string roundString = "Round: ";
        private int round = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player player = new Player("First Player");
            Player computer = new Player("Second Player");

            player.Block += Show_Message;
            player.Wound += Show_Message;
            player.Death += Show_Message;

            computer.Block += Show_Message;
            computer.Wound += Show_Message;
            computer.Death += Show_Message;

            label1.Text = player.Name;
            label2.Text = computer.Name;

            progressBar1.Value = 100;
            progressBar2.Value = 100;

            label3.Text = roundString + Convert.ToString(round);
        }

        private static void Show_Message(object sender, FightEventArgs e)
        {
            
        }
    }
}
