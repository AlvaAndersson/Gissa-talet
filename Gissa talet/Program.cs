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

                //Sätt menyvalet och spelarens tal till 0
                string menyVal = "0";
                int spelarensTal = 0;

                Random randomTal = new Random();
                string senasteVinnaren = ("ingen");

                Console.WriteLine("Välkommen till gissa talet!");

                Console.WriteLine();

                Console.WriteLine("Välj ett av alternativen nedan:");

                string ändraTal = "0";

                while (menyVal != "5")
                { 

                //Skriv en meny
                Console.WriteLine("1. Spela en omgång av gissa talet");
                Console.WriteLine("2. Hur spelar man gissa talet?");
                Console.WriteLine("3. Senaste vinnaren");
                Console.WriteLine("4. Avsluta programmet");
                    Console.WriteLine("5. Ändra talet");

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

                            while (spelarensTal != datornsTal)
                            {


                                //Om talet är lägre
                                if (spelarensTal < datornsTal && spelarensTal < max)
                                {
                                    
                                    Console.WriteLine("Ditt tal var lägre än datorns tal");
                                    spelarensTal = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                //Om talet är högre
                                if (spelarensTal > datornsTal && spelarensTal > min )
                                {

                                    Console.WriteLine("Ditt tal var högre än datorns tal");
                                    spelarensTal = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                }

                                else
                                {
                                    Console.WriteLine("Ditt svar var ogiltigt");
                                }
                                
                            }

                            //Om talet är rätt
                            if (spelarensTal == datornsTal)

                            Console.WriteLine("Grattis du gissade rätt tal!");
                            Console.WriteLine();

                            //Användaren får skriva in sitt namn till senaste vinnaren

                            Console.WriteLine("Skriv in ditt namn");
                            senasteVinnaren = Console.ReadLine();

                            break;

                        // 2. Visa spelets regler
                        case "2":
                            Console.WriteLine();
                            Console.WriteLine("Här kommer en beskrivning på hur man spelar gissa talet:");
                            Console.WriteLine("Spelet går ut på att gissa rätt tal");
                            Console.WriteLine("Reglerna är enkla");
                            Console.WriteLine("Du gissar ett tal och datorn medelar om");
                            Console.WriteLine("talet var rätt eller fel, om talet var fel");
                            Console.WriteLine("får du veta om ditt gissade tal var högre eller lägre");
                            Console.WriteLine();
                            break;

                            //Visa senaste vinnaren

                        case "3":

                            if (senasteVinnaren != "ingen")
                            {
                                Console.WriteLine($"Senaste vinnaren var {senasteVinnaren}.");
                            }
                            else
                            {
                                Console.WriteLine("Ingen har vunnit");
                            }
                            break;

                        // 4. avsluta

                        case "4":
                            break;

                        case "5":
                            while (ändraTal != "2")
                                
                            {
                                Console.WriteLine("1. Ändra max värdet från 10 till ett nytt tal");
                                Console.WriteLine("2. Gå tillbaks till spelet");
                                ändraTal = (Console.ReadLine();

                               if (ändraTal = "1") 


                                    break;
                            }
                            break;

                        // default (ogiltigt svar)

                        default:

                            Console.WriteLine();
                            Console.WriteLine("Du valde inte ett giltigt svar");
                            Console.WriteLine();
                            break;



                    }



                }

                //Mellanrum
                Console.WriteLine();
            }






            
        }
    }
}
