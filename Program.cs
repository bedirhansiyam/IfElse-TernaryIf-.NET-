namespace IfElse_TernaryIf;
class Program
{
    static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;

        // if - else if - else

        if(time >= 6 && time < 11)
            Console.WriteLine("Good morning!");
        else if(time <= 18)
            Console.WriteLine("Have a nice day.");
        else
            Console.WriteLine("Good night!");


        // Ternary if

        string result = time >= 6 && time < 11 ? "Good morning!" : time <= 18 ? "Have a nice day." : "Good night!";
        Console.WriteLine(result);
    }
}
