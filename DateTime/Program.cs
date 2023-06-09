namespace Date
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lütfen tarihi 'dd | MM | yyyy' formatında girin:");

            try
            {
                string inputDate = Console.ReadLine();

                var date = DateTime.ParseExact(inputDate, "dd/MM/yyyy");

                Console.WriteLine("Girilen tarih: " + date.ToString("dd.MM.yyyy"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}