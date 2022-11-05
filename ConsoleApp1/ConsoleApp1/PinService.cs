namespace App
{
    public class PinService
    {
        public void CheckPin(int pin)
        {
            // Instrukcja warunkowa
            if (pin == 1234)
            {
                Console.WriteLine("PIN Prawidłowy!");
            }
            else
            {
                Console.WriteLine("PIN Nieprawidłowy!");
            }
        }
    }
}