﻿using System;
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
        public static int GetSelection(int input=25)
        {
            
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
        public static decimal GetCoin()
        {
            int input;
            int[] choix = new int[6] {0, 1, 2, 3, 4, 5};
            do
            {
                Console.Write(
                    $"[{choix[0]}] = Annuler\n[{choix[1]}] = 5c\n[{choix[2]}] = 10c\n[{choix[3]}] = 25c\n[{choix[4]}] = 1$\n[{choix[5]}] = 2$\n->");
                input = int.Parse(Console.ReadLine());
            } while (input < 0 || input > 5);
            
            
            
            return input;
        }
        static void Main(string[] args)
        {
            Candy[] candies = LoadCandies(); //Declaration d'un tableau de type Candy qui contient tous les donnees des bonbons fichier.data
            Board.Print();
            int select = GetSelection();
            Candy bonbon = GetCandy(select, candies);
            while (bonbon.Stock >= 0)
            {
                if (bonbon.Stock == 0)
                {
                    Board.Print(message:candies[select].Name + " VIDE", select+1, bonbon.Price);
                    select = GetSelection();
                    bonbon = GetCandy(select, candies);
                }
                else
                {
                    Board.Print(candies[select].Name, select+1, bonbon.Price);
                    break;
                }
            }
            Console.WriteLine("Bravo!");
            decimal coin = GetCoin();



























        }
    }
}