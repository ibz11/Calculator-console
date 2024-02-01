class Calculate
{
    public  void add(int num1, int num2)
    {

        int result = num1 + num2;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"The result is {result}");

        }

       public  void subtract(int num1, int num2)
        {

            int result = num1 - num2;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine( $"The result is {result}");

    }

    public  void divide(int num1, int num2)
    {

        int result = num1 / num2;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(
            $"The result is {result}");

        }

       public  void multiply(int num1, int num2)
        {

            int result = num1 * num2;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(
                $"The result is {result}\n");

    }



}


class Calculator
{
    static void Main()
    {
        Calculate app = new Calculate();
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
   
            Console.WriteLine("CALCULATOR");
            Console.WriteLine("-----------\n");

            Console.WriteLine("1.Add");
            Console.WriteLine("2.Subtract");
            Console.WriteLine("3.Divide");
            Console.WriteLine("4.Multiply\n");

            Console.Write("Choose your option:");
            var choice = Console.ReadLine();


            var num1 = 0;
            var num2 = 0;
            switch (int.Parse(choice))
            {
                case 1:
                    Console.WriteLine("--Addition--");
                    Console.Write("Type the first number: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("\n");

                    Console.Write("Type the second number: ");
                    num2 = int.Parse(Console.ReadLine());

                    app.add(num1, num2);
                    break;

                case 2:
                    Console.WriteLine("--Subtraction--");
                    Console.Write("Type the first number: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("\n");

                    Console.Write("Type the second number: ");
                    num2 = int.Parse(Console.ReadLine());
                    app.subtract(num1, num2);
                    break;


                case 3:
               
                    Console.WriteLine("--Division--");
                    Console.Write("Type the first number: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("\n");

                    Console.Write("Type the second number: ");
                    num2 = int.Parse(Console.ReadLine());
                    app.divide(num1, num2);
                    break;

                case 4:

                    Console.WriteLine("--Multiplication--");
                    Console.Write("Type the first number: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("\n");

                    Console.Write("Type the second number: ");
                    num2 = int.Parse(Console.ReadLine());
                    app.multiply(num1, num2);
                    break;


                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong Input !! please try again");
                    Console.WriteLine("\n");
                    break;













            }
        }

    }
}