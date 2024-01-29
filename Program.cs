namespace RateSpielMini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen beim Ratespiel");
            Random random = new Random(); // feneriert neue ZUfällige Zahl 
            int zielZahl = random.Next(1, 101);
            int maxVersuche = 5;
            int versuche = 0; // bevor man was eingibt werden die versuche auf null gesetzt weil man noch nichts eingegeben hat 
            bool geraten = false;

            while (!geraten && versuche < maxVersuche) // Dieser Code wird wiederholt, solange 'geraten' falsch ist UND die Anzahl der 'versuche' kleiner als 'maxVersuche' ist.
            {
                Console.Write("Geben Sie Ihre Vermutung ein (1-100): ");
                string eingabe = Console.ReadLine();

                if (int.TryParse(eingabe, out int vermutung))
                {
                    versuche++;

                    if (vermutung < zielZahl)
                    {
                        Console.WriteLine("Zu niedrig!");
                    }
                    else if (vermutung > zielZahl)
                    {
                        Console.WriteLine("Zu hoch!");
                    }
                    else
                    {
                        geraten = true;
                        Console.WriteLine($"Sie haben die richtige Zahl in {versuche} Versuchen erraten!");
                    }

                    // Motivationsspruch nach jedem Versuch
                    GibMotivationsspruch();
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe");
                }
            }

            if (!geraten)
            {
                Console.WriteLine($"Leider keine richtige Zahl in {maxVersuche} Versuchen erraten. Die richtige Zahl war {zielZahl}.");
            }

            Console.ReadLine();
        }

        static void GibMotivationsspruch()
        {
            
            string[] motivationssprueche = {
            "Gut gemacht! Weiter so!",
            "Du bist auf dem richtigen Weg!",
            "Nicht aufgeben, du kommst näher!",
            "Fantastisch! Du schaffst das!",
            
        };

            Random random = new Random();
            int index = random.Next(motivationssprueche.Length);

            Console.WriteLine($"Motivation: {motivationssprueche[index]}");
        }
        }
    }

