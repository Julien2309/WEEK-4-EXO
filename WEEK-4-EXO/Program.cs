using System;

namespace WEEK_4_EXO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter which exercice you want to test (1, 2, 3...)");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    Exercice1();
                    break;
                case "3A":
                    Exercice3A();
                    break;
                case "3":
                    Exercice3();
                    break;
                case "5":
                    Exercice5();
                    break;
                case "6":
                    Exercice6();
                    break;
                case "7":
                    Exercice7();
                    break;
                case "8":
                    Exercice8();
                    break;

                default:
                    break;
            }


            Console.ReadKey();
            Console.Clear();
        }
        
        #region Exercice 1
        static void Exercice1()
        {
            Console.WriteLine("Enter any word (it will exchange its firts and last character");
            string mot = Console.ReadLine();
            string newmot = mot;
            char stockF;

            if (mot != null && mot.Length > 1)
            {
                char[] tab = new char[mot.Length];
                for (int i = 0; i < mot.Length; i++) //We create an array of characters
                {
                    tab[i] = mot[i];
                }
                stockF = tab[0];
                tab[0] = tab[tab.Length - 1];
                tab[tab.Length - 1] = stockF;
                newmot = new string(tab);
            }
            Console.WriteLine($"The modified word is {newmot}");
        }
        #endregion

        #region Exercice 2 FAIL
        static void Exercice2()
        {
            #region user fill in
            Console.WriteLine("Enter the size of the base array ");
            int basesize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fill in the base array");
            int[] baze = new int[basesize];
            for (int i = 0; i < basesize - 1; i++)
            {
                baze[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the size of the test array ");
            int testsize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fill in the test array");
            int[] test = new int[testsize];
            for (int i = 0; i < testsize - 1; i++)
            {
                test[i] = Convert.ToInt32(Console.ReadLine());
            }
            #endregion

            bool equal = false; //We start off thinking the 2 arrays aren't similar
            if (testsize >= basesize)
            {
                int iteration = testsize - testsize + 1; //The number of test we're going to do on the arrays
                for (int i = 0; i <= iteration; i++)
                {
                    for (int j = 0; j < basesize; j++)
                    {
                        if (baze[j] != test[j]+iteration)
                        {

                        }
                    }
                }
            }
        }

        static bool Similaire(int[] tab, int[] verif)
        {
            bool simi = true; //We start off thinking it's true
            if (tab.Length >= verif.Length)
            {
                for (int i = 0; i < verif.Length; i++)
                {
                    if (tab[i] != verif[i])
                    {
                        simi = false;
                    }
                }
            }
            else { simi = false; }
            return simi;
        }

        #endregion

        #region Exercice 3

        #region Exercice 3A
        static void Exercice3A()
        {
            Console.WriteLine("Enter the character you want to know the ASCII value of");
            char letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"The ASCII Value of {letter} is {(int)letter}");
        }
        #endregion

        static void Exercice3()
        {
            Console.WriteLine("Enter a word you want to sort in descending order");
            string word = Console.ReadLine();
            int[] tab = new int[word.Length];
            char[] sorted = new char[word.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = (int)word[i]; //We writethe ASCII vaue directly into the tab
            }
            Array.Sort(tab); //We sort the tab
            for (int j = 0; j < tab.Length; j++)
            {
                sorted[j] = (char)tab[j];
            }
            Console.WriteLine(word);
            Console.Write("The sorted word in descending order is: ");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(sorted[i]);
            }
        }
        #endregion

        #region Exercice 4
        static void Exercice4()
        {
            Console.WriteLine("Enter the string you want to compress");
            string word = Console.ReadLine();

            #region char array creation
            char[] tab = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                tab[i] = word[i];
            }
            #endregion

            



        }



        #endregion

        #region Exercice 5
        static void Exercice5()
        {
            int somme = 0;
            for (int n = 0; n < 1000; n++)
            {
                int u = 0;
                int t = 0; //tenth
                int h = 0; //hundreth

                h = n / 100 - (n % 100 / 100);
                u = n % 100;
                t = (u - (u % 10)) / 10;
                u = u % 10;

                somme = (u * u * u) + (t * t * t) + (h * h * h);

                if (somme == n)
                {
                    Console.WriteLine($"{n} is an Armstrong Number");
                }
                somme = 0;
            }
        }
        


        #endregion

        #region Exercice 6
        static void Exercice6()
        {
            #region array creation
            Console.WriteLine("Enter the size of the array you want to create");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fill in the array");
            int[] tab = new int[size];
            for (int i = 0; i < size; i++)
            {
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            #endregion

            Array.Sort(tab);

            for (int i = 0; i <= tab[size-1]; i++)
            {
                int count = 0;

                for (int j = 0; j < size; j++)
                {
                    if (i == tab [j])
                    {
                        count++;
                    }
                }
                if (count !=0)
                {
                    Console.WriteLine($"{i} appears {count} times in the array");
                }
            }
        }

        #endregion

        #region Exercice 7
        static void Exercice7()
        {
            Console.WriteLine("Enter the number to put under a factorrial");
            int a = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 0; i < a; i++)
            {
                fact = fact * (a - i);
            }
            Console.WriteLine($"{a}! = {fact}");
        }


        #endregion

        #region Exercice 8
        static void Exercice8()
        {
            Console.WriteLine("Enter a sentence");
            string phrase = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine($"There is {count} white spaces in your sentence");
            

        }
        #endregion

        #region Exerice 9


        #endregion
    }
}
