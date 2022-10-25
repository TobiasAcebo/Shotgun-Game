using System;
using System.Collections.Generic;
using System.Text;

namespace Shotgun
{
    class Player
    {
        public string Choice { get; set; }
        public int Bullets { get; set; }

        public Player()
        {
            Choice = "";
            Bullets = 0;
        }

        public static void PlayerReload(Player player)
        {
            player.Bullets += 1;
        }

        public static void PlayerShoot(Player player)
        {
            player.Bullets -= 1;
        }

        public static void PlayerShotgun(Player player)
        {
            player.Bullets -= 3;
        }

        public static void PlayerInGame(Player player)
        {
            if(player.Choice == "Skjut")
            {
                PlayerShoot(player);
            }

            else if (player.Choice == "Ladda")
            {
                PlayerReload(player);
            }

            else if (player.Choice == "Shotgun")
            {
                PlayerShotgun(player);
            }
        }

    }
}
