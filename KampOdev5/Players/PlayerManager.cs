using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev5
{
    public class PlayerManager
    {

        List<Player> players = new List<Player>() { };
        public void Add(Player player)
        {
            Console.WriteLine("BİLGİLER : " +""+
                player.PlayerFirstName +""+
                player.PlayerLastName +" "+
                player.PlayerId +
                " \nBU BİLGİLERE AİT KULLANICI SİSTEMİMİZE EKLENDİ"
            );
        }
        public void Delete(string PlayerFirstName)
        {
            foreach (var player in players)
            {
                if (player.PlayerFirstName == PlayerFirstName)
                {
                    players.Remove(player);
                    Console.WriteLine("BİLGİLER: " + player.PlayerFirstName +
                        player.PlayerLastName +
                        player.NationalNumber +
                        player.PlayerId +
                        "\nBU KULLANICI SİSTEMİMİZDEN ÇIKARILDI : ");
                    break;
                }
                else
                {
                    continue;
                }           
            }
        }

        public void ListPlayer()
        {
            int i = 1;
            foreach (var player in players)
            {
                Console.WriteLine("-------------\n");
                Console.WriteLine( "Kullanıcı Listesi : \n",i ,player.PlayerFirstName,player.PlayerLastName);

                i += 1;
            }

        }
    }
}
