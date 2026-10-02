namespace Topic_5_Assignment
{
    internal class Program
    {

        static void Typer(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);

                Thread.Sleep(20);
            }
            Console.WriteLine();
        }

        static void TyperInd(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);

                Thread.Sleep(20);
            }
        }


        static void part1()
        {

            double weight;
            string planet, venus, mars, jupiter, saturn, uranus, neptune;
            bool done = false;


            Typer("Hello, Julio Cesar Chevez Mark VII.");
            TyperInd("Please enter your current Earth weight: ");

            while(!double.TryParse(Console.ReadLine(), out weight) || weight < 0)
                Console.WriteLine("Invalid input, try again");

            Typer("I have information of the following planets:");
            Console.WriteLine("");
            Typer("1. Venus 2. Mars 3. Jupiter");
            Typer("4. Saturn 5. Uranus 6. Neptune");
            Console.WriteLine("");
            

            while (!done)
            {
                Typer("So, which planets will you be visiting boss?");
                planet = Console.ReadLine().ToLower();
                done = true;
                if (planet == "venus")
                {
                    Typer("Your weight will be " + Math.Round(weight * 0.91, 2) + " on Venus");
                    

                }
                else if (planet == "mars")
                {
                    Typer("Your weight will be " + Math.Round(weight * 0.38, 2) + " on Mars.");
                }
                else if (planet == "jupiter")
                {
                    Typer("Your weight will be " + Math.Round(weight * 2.36, 2) + " on Jupiter.");
                }
                else if (planet == "saturn")
                {
                    Typer("Your weight will be " + Math.Round(weight * 1.06, 2) + " on Saturn.");
                }
                else if (planet == "uranus")
                {
                    Typer("Your weight will be " + Math.Round(weight * 0.89, 2) + " on Uranus.");
                }
                else if (planet == "neptune")
                {
                    Typer("Your weight will be " + Math.Round(weight * 1.14, 2) + " on Neptune");
                }
                else
                {
                    done = false;
                    Typer("You have not selected a planet that was listed. Please try again.");
                }

                Console.WriteLine();

                Console.WriteLine("Press enter to begin part 2");
                Console.ReadLine();
                Console.Clear();
            }
            
        }

        static void part2()

        {

            double num1, num2;
            string symbol;

            Console.WriteLine("Welcome to the calculator.");
            Console.WriteLine();
            Console.WriteLine("Please input your first number");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("You did not insert a number. Please try again.");
            }
            Console.WriteLine();
            Console.WriteLine("Please input your symbol (+,-,*,/, sqrt)");
            symbol = Console.ReadLine().ToLower();
            Console.WriteLine();
            Console.WriteLine("Please input your second number");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("You did not insert a number. Please try again.");
            }
            Console.WriteLine();

            bool done = false;
          
                if (symbol == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (symbol == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (symbol == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (symbol == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (symbol == "sqrt")
            {
                Console.WriteLine(Math.Pow(num1, 1.0 / num2));   //you get NaN by sqrt negative numbers because of imaginary nums or smth ig
            }

        }

        static void part3()
        {
            Console.WriteLine("Hello, I will be asking you 4 or more random questions to test your knowledege.");
        }

        static void Main(string[] args)
        {

            part2();

        }
    }
}
