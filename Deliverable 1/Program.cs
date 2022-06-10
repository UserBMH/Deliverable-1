using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int loop = 1;



        Console.WriteLine("How many people are we making PB&J sandwiches for?: "); //intro

        while (loop <= 1) //will loop unless ended during restart sting
        {


            double sandwich = double.Parse(Console.ReadLine()); //create sandwhich variable and translates from string to double

            double bread_unit = 2 * sandwich;          //2 bread per sandwich
            double bread = bread_unit / 28;            //28 bread units (slices) per bread (loaf)


            double pbutter_unit = 2 * sandwich;        //2 tbsp per sandwich
            double pbutter = pbutter_unit / 32;        //32 tbsp pbutter_unit per pbutter (jar)

            double jelly_unit = 4 * sandwich;          //4 tsp per sandwich
            double jelly = jelly_unit / 48;            //48 tsp per jelly (jar)



            Console.WriteLine("You need " + sandwich + " sandwiches. " + Math.Ceiling(bread) + " Loaves of bread. " + Math.Ceiling(pbutter) + " jars of peanut butter. " + Math.Ceiling(jelly) + " jars of jelly."); //output total req mats collective units. Math.Ceiling rounds partial numbers up.
            Console.WriteLine("which is..." + bread_unit + " slices of bread. " + pbutter_unit + " tablespoons of peanut butter. " + jelly_unit + " teaspoons of jelly."); //output total req mats indiv units

            Console.WriteLine("Cook again? Enter y or yes to continue or any other key to end "); //Repeat while condition,

            string restart = (Console.ReadLine()); //restart if-else either loops program or end based on user input

            if (restart.Contains("yes") == true)

            {
                Console.WriteLine("How many people are we making PB&J sandwiches for?: ");
            }

            else if (restart.Contains("y") == true)

            {
                Console.WriteLine("How many people are we making PB&J sandwiches for?: ");
            }


            else
            {
                Console.WriteLine("Goodbye"); System.Environment.Exit(0);
            }







        }




    }
}