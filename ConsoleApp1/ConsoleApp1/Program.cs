namespace App
{
    public class Program
    {
        public static void Main()
        {
            // Zmienne
            string greeting = "Hello World! :)" + " OK";
            int pin = 1234;

            // Wywołanie obiektu:
            PinService pinService = new PinService();
            pinService.CheckPin(pin);

            // Lista (tablica dynamiczna)
            List<int> tab = new List<int>();
            tab.Add(1);
            tab.Add(2);
            tab.Add(3);
            tab.Add(4);
            tab.Add(5);

            // Pętla iteracyjna
            for (int i = 0; i < tab.Count; i++)
            {
                if (i == 4)
                {
                    tab[i] = 0;
                }

                Console.WriteLine("tab[" + i + "] = " + tab[i]);
            }

            // Output
            Console.WriteLine(greeting);

            // Custom object:
            Bucket myBucket = new Bucket();
            Console.WriteLine(myBucket.Color);
            myBucket.Repait("Zielony");
            Console.WriteLine(myBucket.Color);
        }
    }
}