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
            int sayı = Convert.ToInt32(Console.ReadLine());
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

            try
            {
              // int a = int.Parse(null);  
              //int a = int.Parse("test");
              int a = int.Parse("-200000000000");
            }
            catch (ArgumentNullException ex)
            {
                
              Console.WriteLine("Boş Deger Girme lan : ");
              Console.WriteLine(ex);  
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri toplama uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok Küçük yada çok büyük bir değer girdiniz");
                Console.WriteLine(ex);
            }    
           

        }
    }
}
