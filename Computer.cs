using System;
using System.Collections.Generic;
using System.Text;

namespace Shotgun
{
    class Computer
    {
        public string Choice { get; set; }
        public int Bullets { get; set; }

        public Computer()
        {
            Choice = "";
            Bullets = 0;
        }

        public static void ComputerReLoad(Computer cpu)
        {
            cpu.Bullets += 1;
        }

        public static void ComputerShoot(Computer cpu)
        {
            cpu.Bullets -= 1;
        }

        public static void ComputerShotgun(Computer cpu)
        {
            cpu.Bullets -= 3;
        }

        public static string ComputerGame(Computer cpu, Player player)
        {
            Random rnd = new Random();

            if(player.Bullets == 0 && cpu.Bullets == 0)
            {
                cpu.Choice = "Ladda";
                ComputerReLoad(cpu);
            }

            else if(cpu.Bullets == 0)
            {
                int random = rnd.Next(1, 3);
                if(random == 1)
                {
                    cpu.Choice = "Ladda";
                    ComputerReLoad(cpu);
                }
                else
                {
                    cpu.Choice = "Blockera";
                }
            }

            else if(cpu.Bullets >= 1)
            {
                int random2 = rnd.Next(1, 3);
                if(random2 == 2)
                {
                    cpu.Choice = "Skjut";
                    ComputerShoot(cpu);
                }
                else
                {
                    cpu.Choice = "Blocka";
                }
            }

            else if (cpu.Bullets >= 3)
            {
                int random3 = rnd.Next(1, 4);
                if(random3 == 4)
                {
                    cpu.Choice = "Shotgun";
                    ComputerShotgun(cpu);
                }
                else if (random3 == 3)
                {
                    cpu.Choice = "Blocka";
                }
                else if (random3 == 2)
                {
                    cpu.Choice = "Skjut";
                    ComputerShoot(cpu);
                }
                else
                {
                    cpu.Choice = "Ladda";
                    ComputerReLoad(cpu);
                }
            }
            return cpu.Choice;
        }
    }
}
