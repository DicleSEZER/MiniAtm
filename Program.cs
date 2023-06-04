using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniAtm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nasıl bir işlem yapmak istediğini sor
            //1-Bakiye görüntüleme
            //2-Para çekme
            //3-Para yatırma
            //q ya basarsa çıkış yaptıracağız

            int bakiye = 1000;
            Console.WriteLine("Hoşgeldiniz");
            Console.WriteLine("yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("1-Bakiye görüntüleme");
            Console.WriteLine("2-Para çekme");
            Console.WriteLine("3-Para yatırma");
            Console.WriteLine("q-Çıkış yapma");


            string secim = Console.ReadLine();
           
             

            if (secim == "1")
            {
                Console.WriteLine("Şuanki bakiyeniz : "+bakiye);

                Console.ReadLine();
            }else if (secim == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı girin :");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
               
                if(cekilecek_tutar <= bakiye)
                {
                    Console.WriteLine("Kalan tutar:" + (bakiye - cekilecek_tutar));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Bakiyenizden fazla para çekemezsiniz");
                    Console.ReadLine();
                }
            }
            else if (secim == "3")
            {
                Console.WriteLine("Yatırılacak tutarı girin:");
                int yatırılacak_tutar= Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Yeni tutar:"+(bakiye+yatırılacak_tutar));
                Console.ReadLine();
            }
            else if(secim == "q") {
                Console.WriteLine("Çıkış yapılıyor");
                Console.WriteLine("Çıkış yapıldı");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir işlem seçiniz");
                Console.ReadLine();
            }
        }
    }
}
