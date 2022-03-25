using System;

namespace hatayönetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Bir Sayı Giriniz:");
            int sayı = Convert.ToInt32(Console.ReadLine));
            Console.WriteLine("Girmiş oldugunuz sayı :" + sayı);
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı");
            }



        }
    }
}
