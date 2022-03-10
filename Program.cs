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
            Board.Print();
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
            //string messageb = Board.PadBoth()
            Board.Print(selection:input);
            //Board.Print(selection:GetSelection(input));
            return input;
        }

        /*public static int GetCandy(int input)
        {
            Board.Print(LoadCandies()candies[input]);
        }*/
        static void Main(string[] args)
        {
            //LoadCandies();
            Data dataManager = new Data();
            Candy[] candies = dataManager.LoadCandies();
            //int input = GetSelection();
            //candies = 
            //Board.Print(selection:input);
            //Candy[] candies = LoadCandies();
            //Candy[] candies = Data.LoadCandies();
            int select = GetSelection();
            Board.Print(candies[select].Name, selection:select);



























        }
    }
}