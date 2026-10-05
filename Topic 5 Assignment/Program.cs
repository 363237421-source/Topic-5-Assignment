namespace Topic_5_Assignment
{
    internal class Program
    {

        static void Typer(string text) //extra
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);

                Thread.Sleep(20);
            }
            Console.WriteLine();
        }

        static void TyperInd(string text)  //extra extra
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
            }
            Console.WriteLine();

            Console.WriteLine("Press enter to begin part 2");
            Console.ReadLine();
            Console.Clear();
        }

        static void part2()

        {

            double num1, num2;
            string symbol;
            string wordAns = "The answer is "; //Helps me

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
            while (symbol != "+" && symbol != "-" && symbol != "*" && symbol != "/" && symbol != "sqrt")
            {
                Console.WriteLine("You did not insert the right symbol, please try again");
                symbol = Console.ReadLine();
            }

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
                Console.WriteLine(wordAns + (num1 + num2));
            }
            else if (symbol == "-")
            {
                Console.WriteLine(wordAns + (num1 - num2));
            }
            else if (symbol == "*")
            {
                Console.WriteLine(wordAns + (num1 * num2));
            }
            else if (symbol == "/")
            {
                Console.WriteLine(wordAns + (num1 / num2));
            }
            else if (symbol == "sqrt")
            {
                Console.WriteLine(wordAns + Math.Pow(num1, 1.0 / num2));   //you get NaN by sqrt negative numbers because of imaginary nums or smth ig
            }

            Console.WriteLine();
            Console.WriteLine("Press enter for part 3");
            Console.ReadLine();
            Console.Clear();

        }

        static void part3()
        {
            int points = 0;
            string answer;

            Typer("Hello, I will be asking you 5 questions to test your knowledege.");
            Typer("Press enter to begin");
            Console.ReadLine();
            Console.WriteLine();
            Typer("First question...");
            Typer("What is the capital of France?");
            answer = Console.ReadLine().ToLower();
            if (answer == "paris")
            {
                Typer("Correct! 1/5 questions answered.");
                points =+ points + 1;
            }
            else
            {
                Typer("Wrong! 1/5 questions answered.");
            }
            
            Console.WriteLine();
            Typer("Next question...");
            Typer("What time does school start?");
            answer = Console.ReadLine().ToLower();
            if (answer == "8:20" || answer == "8:20am")
            {
                Typer("Correct! 2/5 questions answered.");
                points =+ points + 1;
            }
            else
            {
                Typer("Wrong! 2/5 questions answered.");
            }

            Console.WriteLine();
            Typer("Next question...");
            Typer("What is einsteins most famous equation? (Write it exactly how the formula is shown)");
            answer = Console.ReadLine();
            if (answer == "E=mc^2")
            {
                Typer("Correct! 3/5 questions answered.");
                points =+ points + 1;
            }
            else
            {
                Typer("Wrong! 3/5 questions answered.");
            }

            Console.WriteLine();
            Typer("Next question...");
            Typer("True or False. Did Leonardo Dicaprio paint the orginal Mona Lisa painting?");
            answer = Console.ReadLine().ToLower();
            if (answer == "false")
            {
                Typer("Correct! Leonardo Dicaprio did not paint the orginal Mona Lisa. 4/5 questions answered");
                points =+ points +1;
            }
            else
            {
                Typer("Wrong! Leonardo Dicaprio did not paint the orginal Mona Lisa. 4/5 questions answered");
            }

            Console.WriteLine();
            Typer("Warning, this question is very hard, press enter if you are ready...");
            Console.ReadLine();
            Typer("Alright then, how many digits of pi is needed to calculate the circumference");
            Typer("of the entire observable universe with an error margin smaller than a single hydrogen atom?");
            Typer("a) 13");
            Thread.Sleep(1500);
            Typer("b) 23");
            Thread.Sleep(1500);
            Typer("c) 39");
            answer = Console.ReadLine().ToLower();
            if (answer == "39" || answer == "c)" || answer == "c")   //ANSWER HERE
            {
                Typer("Wow! You got that correct! 5/5 questions answered press enter to see how well you did.");
                points =+ points + 1;
            }
            else
            {
                Typer("Wrong... 5/5 questions answered.");
                Thread.Sleep(1000);
                Typer("...");
                Thread.Sleep(1000);
                Typer("...");
                Thread.Sleep(1000);
                Typer("Anyways press enter to see how well you did.");
            }
            Console.ReadLine();

            Console.WriteLine();
            if (points == 5)
            {
                Typer("Congratulations! You got all the answeres correct, you must be a genius!");
            }
            else if (points == 0)
            {
                Typer("Huh, you answered all my questions wrong. You must be having a bad day.");
            }
            else
            {
                Typer("Thank you for answering my questions. Out of the 4 questions you got " + points + " correct");
            }

            Thread.Sleep(4000);
            TyperInd(".............. you may now leave. =)");
        }

        static void Main(string[] args)   //Methods being executed eher
        {
            part1();
            part2();
            part3();

        }
    }
}
