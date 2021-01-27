using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev5
{
  class GameManager : Program
    {
        List<Game> games = new List<Game>() { };

        public void Add(Game game)
        {
            

            games.Add(game);
            Console.WriteLine(" Oyun Eklendi : "+game.GameName  );
        }


        public void Update(Game game)
        {

         }
        public void Delete(string GameName)
        {
            foreach (var game in games)
            {
                if (game.GameName == GameName)
                {
                    Console.WriteLine(game.GameName+" Adlı oyun Silindi");
                    break;

                }
                else
                {
                    continue;
                }
            }

        }
        public void ListGame()
        {
            int i = 1;
            foreach (var game in games)
            {
                Console.WriteLine();
                i +=1 ;
            }
        }

     
        }
        
          
        
    }

