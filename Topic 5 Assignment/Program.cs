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


            Typer("Hello, Julio Cesar Chevez Mark VII.");
            TyperInd("Please enter your current Earth weight: ");
            double.TryParse(Console.ReadLine(), out weight);
            Typer("I have information of the following planets:");
            Console.WriteLine("");
            Typer("1. Venus 2. Mars 3. Jupiter");
            Typer("4. Saturn 5. Uranus 6. Neptune");
            Console.WriteLine("");
            Typer("So, which planets will you be visiting boss?");
            planet = Console.ReadLine().ToLower();


            if (planet == "venus")
            {
                Typer("Your weight will be " + Math.Round(weight * 0.91, 2) + " on Venus");
            }
            if (planet =="mars")
            {
                Typer("Your weight will be " + Math.Round(weight * 0.38, 2) + " on Mars.");
            }
            if (planet == "jupiter")
            {
                Typer("Your weight will be " + Math.Round(weight * 2.36, 2) + " on Jupiter.");
            }
            if (planet == "saturn")
            {
                Typer("Your weight will be " + Math.Round(weight * 1.06, 2) + " on Saturn.");
            }
            if (planet == "uranus")
            {
                Typer("Your weight will be " + Math.Round(weight * 0.89, 2) + " on Uranus.");
            }
            if (planet == "neptune")
            {
                Typer("Your weight will be " + Math.Round(weight * 1.14, 2) + " on Neptune");
            }

        }

        static void Main(string[] args)
        {
            part1();
        }
    }
}
