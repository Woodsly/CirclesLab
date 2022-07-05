using CirclesLab;

Console.WriteLine("Welcome to the Circle Tester.");
double radius;
int count = 0;
bool runProgram = true;
while (runProgram)
{
    while (true)
    {
        Console.WriteLine("Please enter a radius: ");
        //validating user entry
        if (double.TryParse(Console.ReadLine(), out radius) && radius > 0)
        {
            //if number is valid double and over 0 program accepts
            Console.WriteLine("Calculating...");
            break;
        }
        else
        {
            //if number can't parse or less than 0 - rejects
            Console.WriteLine("Please enter a valid radius!");
        }
    }

    //creating an instance of circle
    Circle myCircle = new Circle(radius);
    Console.Write("Circumference: ");
    Console.WriteLine(myCircle.CalculateFormattedCircumference());
    Console.Write("Area: ");
    Console.WriteLine(myCircle.CalculateFormattedArea());
    Console.WriteLine("");
    runProgram = GoAgain();
    count++;
    
}
Console.WriteLine($"Thanks for using our program!  You built {count} circles.");

//Josh's run again method
static bool GoAgain()
{
    while (true)
    {
        Console.WriteLine("Do you want to go again(y/n)?");
        string input = Console.ReadLine();
        try
        {
            if (input.ToLower().Trim() == "y")
            {
                return true;
            }
            else if (input.ToLower().Trim() == "n")
            {
                return false;
            }
            else
            {
                throw new Exception("Not a valid option, please try again.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}