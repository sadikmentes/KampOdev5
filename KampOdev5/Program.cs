using System.Collections.Generic;
using System;
namespace KampOdev5
{
    public class Program
    {
        public static string GameName { get; private set; }

        static void Main(string[] args)
        {
            Player player1 = new Player()
            {
                PlayerFirstName = "Sadık ",
                PlayerLastName = "Menteş ",
                PlayerId = 123,
                NationalNumber = "123456789\n" +
                "------------"

            };
            Player player2 = new Player()
            {
                PlayerFirstName = " Acun ",
                PlayerLastName = "Ilıcalı  ",
                PlayerId = 456,
                NationalNumber = "987654321 \n" +
               "-----------"

            };

            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player1);
            playerManager.Add(player2);

            GameManager gameManager = new GameManager();

            gameManager.Add(new Game()
            {
                GameName = "PlayerUnknown's Battlegrounds",
                GameType = "Action/Survivor",
                DeveloperCompany = "PUBG Corporation, Krafton, xFAIRx",
                CurrentPrice = 89
            });
            gameManager.Add(new Game()
            {
                GameName = "Counter Strike 1.6",
                GameType = "FPS/Action",
                DeveloperCompany = "Valve",
                CurrentPrice = 39
            });
            gameManager.Add(new Game()
            {
                GameName = "Zula",
                GameType = "MMOFPS ",
                DeveloperCompany = " MadByte Games",
                CurrentPrice = 99
            });

            while (true)
            {
                Console.WriteLine("----SİZE ÖZEL MENÜMÜZ-----\n");
                Console.WriteLine("_______________________\n");
                Console.WriteLine("1-Yeni oyuncu Ekle\n2-Mevcut oyuncuyu sil\n3-Oyun Ekleme\n4-Mevcut oyunu Silme");
                Console.WriteLine("________________________\n");
                int option = Convert.ToInt16(Console.ReadLine());
                Console.Clear();

                if (option == 1)
                {
                    Console.WriteLine("Sisteme Eklemek istediğiniz yeni oyuncunun bilgilerini giriniz");
                    Console.WriteLine("Türkiye Cumhuriyeti Kimlik Numarası(sadece ilk 9 rakamı):\n");
                    string NationalNumber = Console.ReadLine();
                    Console.WriteLine("İsminiz: ");
                    string PlayerFirstName = Console.ReadLine();
                    Console.WriteLine("\nSoyadınız: ");
                    string PlayerLastName = Console.ReadLine();

                    playerManager.Add(new NewPlayer() { PlayerFirstName = PlayerFirstName, PlayerLastName = PlayerLastName, NationalNumber = NationalNumber });
                }
                else if (option == 2)
                {
                    Console.WriteLine("Silmek İstediğiniz Oyuncunun Oyuncu Id'sini giriniz:");
                    playerManager.Delete(Console.ReadLine());
                    Console.WriteLine("OYUNCU SİLİNDİ");
                }



                else if (option == 3)
                {
                    Console.WriteLine("Eklemek İstediğiniz Oyununun :");
                    Console.WriteLine("Adı: ");
                    string GameNumber = Console.ReadLine();
                    Console.WriteLine("Yapımcısı:");
                    string DeveloperCompany = Console.ReadLine();
                    Console.WriteLine("Oyununuzun Türü");
                    string GameType = Console.ReadLine();
                    Console.WriteLine("Fiyatı: ");
                    int CurrentPrice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    gameManager.Add(new Game() { GameName = GameName, DeveloperCompany = DeveloperCompany, GameType = GameType, CurrentPrice = 12 });

                }
                else if (option == 4)
                {
                    Console.WriteLine("Silmek istediğiniz oyunun ADINI giriniz:");
                    gameManager.Delete(Console.ReadLine());
                }
            }
            while (true)
            {
                Console.WriteLine("**********İNDİRİMLER**********");
                Console.WriteLine("1 -YAZ İNDİRİMİ \n2- KIŞ İNDİRİMİ");
                Console.WriteLine("|||||||||||||||||||||||||||||||||");

                int option2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (option2 == 1)
                {
                    Console.WriteLine("Kampanya Seçiniz");
                   string name = Console.ReadLine();
                    Console.WriteLine(" Yaz İndirim Kodu Hesabınıza Uygulandı.Her oyun için geçerlidir");
                    
                }
                else if ( option2 == 2)
                {
                    string name = Console.ReadLine();
                    Console.WriteLine("Kış indirim Kodu Hesabınıza uygulandı");

                }
                else
                {Console.WriteLine("Programdan çıkış yaptınız.\nİyi günler...");
                break;
                    break;
                }
               
            }
            {
                
            }
        }
                


}
        }
    
