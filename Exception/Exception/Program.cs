namespace Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool isNumber = int.TryParse(Console.ReadLine(), out int number);

            //Custom tryParse metodu yazın
            //Try Catch istifade ederek

            bool isNumber = CustomTryParse(Console.ReadLine(), out int number);
            if (isNumber)
            {
                Console.WriteLine($"Sizin daxil etdiyiniz reqem : {number}");
            }
            else
            {
                Console.WriteLine("Siz reqem daxil etmemisiz");
            }
        }

        public static bool CustomTryParse(string value,  out int number)
        {
            try
            {
               number = int.Parse(value);
                return true;
            }
            catch (System.Exception)
            {
                number = 0;
             return false;
            }
        }
    }
}
