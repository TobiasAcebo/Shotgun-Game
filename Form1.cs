using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shotgun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Player player = new Player();
        Computer computer = new Computer();
        bool gameOver = false;
        

        private void CantShootFirstRound(Player player, Computer cpu)
        {
            lbCPUChoice.Text = cpu.Choice;
            lbPlayerAmmo.Text = player.Bullets.ToString();
            lbCPUAmmo.Text = cpu.Bullets.ToString();
           

            if(player.Bullets == 0)
            {
                btnShoot.Enabled = false;
                btnShotgun.Enabled = false;
            }
            else
            {
                btnShoot.Enabled = true;
                if(player.Bullets >= 3)
                {
                    btnShotgun.Enabled = true;
                }
                else
                {
                    btnShotgun.Enabled = false;
                }
            }
        }

        private void CheckGame(Player player, Computer cpu)
        {
           if(player.Choice == "Skjut" && cpu.Choice == "Ladda")
            {
                MessageBox.Show("Player vann! Klicka på starta om spel för att spela igen");
            }

           else if (player.Choice == "Ladda" && cpu.Choice == "Skjut")
            {
                MessageBox.Show("CPU vann! Klicka på starta om spel för att spela igen");
            }

           else if (player.Choice == "Shotgun")
            {
                MessageBox.Show("Player vann! Klicka på starta om spel för att spela igen");
            }

           else if (cpu.Choice == "Shotgun")
            {
                MessageBox.Show("CPU vann! Klicka på starta om spel för att spela igen");
            }
            
        }



        private void StartGame(Player player, Computer cpu, string choice)
        {
            player.Choice = choice;
            cpu.Choice = Computer.ComputerGame(cpu, player);
            Player.PlayerInGame(player);
            CantShootFirstRound(player, cpu);
            CheckGame(player, cpu);
           

        }



        private void btnShoot_Click(object sender, EventArgs e)
        {
            StartGame(player, computer, "Skjut");
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            StartGame(player, computer, "Ladda");
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            StartGame(player, computer, "Blockera");
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            StartGame(player, computer, "Shotgun");
        }

        private void btnReStart_Click(object sender, EventArgs e)
        {
            RestartTheGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void RestartTheGame()
        {
            if (gameOver == true)
            {
                return;

            }

            player.Bullets = 0;
            computer.Bullets = 0;

            lbPlayerAmmo.Text = "Player ammo: " + player.Bullets.ToString();
            lbCPUAmmo.Text = "CPU ammo: " + computer.Bullets.ToString();

            btnShoot.Enabled = false;
        }
    }
}
