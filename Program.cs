using System;
using System.Transactions;
using Project;

namespace Machine_bonbon 
{
    
    internal class Program
    {
        public static Candy[] LoadCandies()
        {
            Candy[] candies;
            Data dataManager = new Data(); /* declaration et reservation de la mémoire de la
            variable structurée(objet) dataManager de type Data */
            candies = dataManager.LoadCandies(); /* appel de la fonction LoadCandies() avec la
            variable structurée dataManager vu que c’est une fonction propre à la classe Data et
            qu’on ne peut pas l’utiliser ailleurs sauf en créant une variable de type Data */
            return candies;
        }
        public static int GetSelection(int nbMaxBonbons =25)
        {
            int input=0;
            
            while (true)
            {
                Console.Write("->");
                input = int.Parse(Console.ReadLine());
                if (input <= 0 || input > 26)
                {
                    Console.WriteLine("Entrer une selection entre 1 & 25 ");
                }
                else
                {
                    break;
                }
                
            }
            Board.Print(selection:input);
            return input-1;
        }

        public static Candy GetCandy(int input, Candy[] candies)
        {
            return candies[input];

        }
        static void Main(string[] args)
        {
            //LoadCandies();
            //LoadCandies();
            Candy[] candies = LoadCandies();
            //int input = GetSelection();
            //candies = 
            //Board.Print(selection:input);
            //Candy[] candies = LoadCandies();
            //Candy[] candies = Data.LoadCandies();
            Board.Print();
            int select = GetSelection();
            Candy bonbon = GetCandy(select, candies);
            //Candy allo = GetCandy(select);
            Board.Print(candies[select].Name, selection:select+1);
            



























        }
    }
}