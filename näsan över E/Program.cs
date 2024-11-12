using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

Övningar övningar = new Övningar();
while (1 == 1)
{
    Console.WriteLine("Tjena, välj ett program att testa");
    Console.WriteLine("1: Metoder sista övningen");
    Console.WriteLine("2: Metoder sista övningen förbättrad");
    int.TryParse(Console.ReadLine(), out int svar);

    switch (svar)
    {
        case 1:
            Console.WriteLine(övningar.GetChoice("båt", "kött", "dunder"));
            Console.ReadLine();
            break;
        case 2:
        Console.WriteLine(övningar.GetChoiceFörBättrad(["båt","kött","dunder","båtigt värre"]));
        Console.ReadLine();
            break;
    }
}


class Övningar
{
    public int GetChoice(string värde1, string värde2, string värde3)
    {
        bool done = false;
        int returnValue = 0;
        while (!done)
        {
            Console.WriteLine($" värde 1: {värde1}, \n värde 2: {värde2}, \n värde 3: {värde3}");
            Console.WriteLine("vilket värde väljer du?");
            string svar = Console.ReadLine();

            if (int.TryParse(svar, out returnValue))
            {
                if (returnValue > 3 && returnValue < 0)
                {
                    Console.WriteLine("ogiltigt svar försök igen");
                }
                else
                {
                    Console.WriteLine($"Du valde värde {returnValue}");
                    done = true;
                }
            }
            else
            {
                Console.WriteLine("ogiltigt svar försök igen");
            }
        }
        return returnValue;
    }


    public int GetChoiceFörBättrad(string[] värden)
    {
        for(int i = 0; i < värden.Length; i++){
            Console.WriteLine($"{i+1}: {värden[i]}");
        }
        bool done = false;
        int returnValue = 0;
        while (!done)
        {
            
            Console.WriteLine("vilket värde väljer du?");
            string svar = Console.ReadLine();

            if (int.TryParse(svar, out returnValue))
            {
                if (returnValue > värden.Length && returnValue < 0)
                {
                    Console.WriteLine("ogiltigt svar försök igen");
                }
                else
                {
                    Console.WriteLine($"Du valde värde {returnValue}");
                    done = true;
                }
            }
            else
            {
                Console.WriteLine("ogiltigt svar försök igen");
            }
        }
        return returnValue;
    }
}
 