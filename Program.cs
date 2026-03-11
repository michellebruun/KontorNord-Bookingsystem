namespace KontorNord_Bookingsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookingService bookingService = new BookingService();
            
            ShowMenu();

            bool isRunning = true;
            while (isRunning)
            {
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        bookingService.CreateBooking();
                        break;
                    case "2":
                        bookingService.EditBooking();
                        break;
                    case "3":
                        bookingService.DeleteBooking();
                        break;
                    case "x":
                    case "X":
                        Console.WriteLine("Afslutter... Farvel :)");
                        isRunning = false;
                        break;
                }
            }
        }
        static void ShowMenu()
        {
            Console.WriteLine("=== Bookingkalender ===");
            Console.WriteLine("1) Opret nyt møde");
            Console.WriteLine("2) Rediger møde");
            Console.WriteLine("3) Slet møde");
            Console.WriteLine("X) Afslut program");
        }
    }
}
