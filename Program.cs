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
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("===================================");
            Console.WriteLine("   MØDELOKALE BOOKING & KALENDER   ");
            Console.WriteLine("===================================");
            Console.ResetColor();
            Console.WriteLine("1) Opret et nyt møde");
            Console.WriteLine("2) Rediger i en mødetid");
            Console.WriteLine("3) Slet et møde");
            Console.WriteLine("X) Afslut programmet");
        }
    }
}
