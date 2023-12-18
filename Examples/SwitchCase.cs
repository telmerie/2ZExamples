using System.Collections;
using System.Security.Cryptography;

class SwitchCase
{

    static void Main()
    {
        int y = 5;
        switch (y)
        {
            case > 4 and 8:
                Console.WriteLine("y is bigger than 4 and 5");
                break;
            case <= 4:
                Console.WriteLine("y is 5.3");
                break;
            case 6:
            case 7:
                Console.WriteLine("y is 6 or 7");
                break;
            default:
                Console.WriteLine("a case for y is not defined");
                break;
        }

        string name = "emily";

        switch (name)
        {
            case "John" or "john":
                Console.WriteLine("John/john");
                break;
            case "Emily":
            case "emily":
                Console.WriteLine("Emily/emily");
                break;
        }
    }



}