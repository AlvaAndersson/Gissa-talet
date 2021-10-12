using System;

namespace Gissa_talet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {

                //Bestäm max min
                int min = 1;
                int max = 11;

                string menyVal = "0";
                int spelarensTal = 0;
                Random randomTal = new Random();

                Console.WriteLine("Välkommen till gissa talet!");

                Console.WriteLine();

                Console.WriteLine("Välj ett av alternativen nedan:");

                //Skriv en meny
                Console.WriteLine("1. Spela en omgång av gissa talet");
                Console.WriteLine("2. Hur spelar man gissa talet?");
                Console.WriteLine("3. Avsluta spelet");

                menyVal = Console.ReadLine();

                //Switch menyval
                switch (menyVal)
                {
                    // 1. spela spelet
                    case "1":
                        int datornsTal = 0;
                        datornsTal += randomTal.Next(min, max);

                        Console.WriteLine("Gissa ett tal");
                        spelarensTal = int.Parse(Console.ReadLine());

                        if (spelarensTal == datornsTal)
                        {
                            Console.WriteLine("Grattis du gissade rätt tal!");
                        }

                        if (spelarensTal < datornsTal)
                        {
                            Console.WriteLine("Ditt tal är lägre");
                        }

                        if (spelarensTal > datornsTal)
                        {
                            Console.WriteLine("Ditt tal är högre");
                        }





                        
                    
                        break;
                    
                    // 2. Visa spelets regler
                    case "2":
                        Console.WriteLine("Här kommer en beskrivning på hur man spelar gissa talet:");
                        Console.WriteLine("Spelet går ut på att gissa rätt tal");
                        Console.WriteLine("Reglerna är enkla");
                        Console.WriteLine("Du gissar ett tal och datorn medelar om");
                        Console.WriteLine("talet var rätt eller fel, om talet var fel");
                        Console.WriteLine("får du veta om ditt gissade tal var högre eller lägre");
                        break;

                    // 3. avsluta

                    case "3":
                        break;

                    

                    // default

                }

                //Mellanrum
                Console.WriteLine();
            }






            
        }
    }
}
