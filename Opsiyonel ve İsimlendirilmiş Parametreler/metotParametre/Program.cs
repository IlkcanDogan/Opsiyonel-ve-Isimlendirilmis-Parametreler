using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotParametre
{
    class Program
    {
        /*
         * Opsiyonel (Optional) Parametreler
         * 
         * Parametrelere varsayılan değerler verebilmek için Opsiyonel parametreleri kullanırız.
         * Varsayılan bir değeri olan parametreye, metot çağırımı esnasında herhangi bir değer 
         * verilmediğinde varsayılan değeri metot içerisinde kullanılır.
         */

        /*
         * Opsiyonel parametreler normal parametrelerden sonra yazılmalıdır. Yani opsiyonel bir
         * parametreden sonra opsiyonel olmayan parametre yazılamaz.
         * 
         * double SilindirHacim(int yaricap, int yukseklik, double pi=3) |Doğru Yazım.
         * double SilindirHacim(int yaricap, double pi=3, int yukseklik) |Yanlış Yazım.
         * double SilindirHacim(double pi=3, int yaricap, int yukseklik) |Yanlış Yazım.
         * double SilindirHacim(int yaricap, double pi=3, int yukseklik=4) |Doğru Yazım.
         */

        private static double CemberinCevresi(double yaricap, double pi = 3)
        {
            return 2 * yaricap * pi;
        }
       
        private static double SilindirHacim(int yaricap, int yukseklik, double pi=3) 
        {
            return pi * yaricap * yaricap * yukseklik;
        }
       
        static void Main(string[] args)
        {
            //_______________________________________________________________//
            // Yarıçap 4 olarak verildi.
            // pi için herhangi bir değer verilmedi ve varsayılan değeri olarak (3) atandı.
            CemberinCevresi(4);

            //Yarıçap 4 olarak verildi.
            //pi 3.14 değerini alacaktır.
            CemberinCevresi(4,3.14);
            //_______________________________________________________________//

            /*
             * İsimlendirilmiş (Named) Parametreler
             * 
             * Metot çağırımı yaparken parametre sırasından bağımsız olarak hangi parametreye
             * hangi değeri atayacağımızı açık bir şekilde belirtebiliriz. İsimlendirilmiş 
             * parametrelerin kullanımı çok sayıda parametre alan metotların okunabilirliğini
             * arttırmaktadır.
             */

            //Hangi parametreye hangi değeri atayacağımızı açık bir şekilde belirttik.
            Console.WriteLine(SilindirHacim(yaricap: 4, pi: 3.14, yukseklik: 56));
            Console.WriteLine(SilindirHacim(yukseklik: 10, yaricap: 5, pi: 3.14));
            Console.WriteLine(SilindirHacim(yukseklik: 3, yaricap: 5));

            Console.ReadLine();
        }
     

    }
}
