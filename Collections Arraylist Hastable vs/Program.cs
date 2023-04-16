using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;               //bu kütüphaneyi eklemeden kod yazamazsın. Bunu eklemeyi unutma.
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Collections_Arraylist_Hastable_vs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList alist = new ArrayList();      // Çeşitli veri tiplerini kapsayan bir sınıf int,string tarzı herşeyi ekleyebilriz bir sınırlandırması olmaz. yazı rakam harf herşeyi ekleyebilriz.
            alist.Add("12");                     // Alist kümsesine nesene ekler  indis no:0.
            alist.Add("12.45m");                 // decimal ekledik çeşitli veri tipi girebliriz  : indis no:1.
            alist.Add(12);
            alist.Add("12.5");
            alist.Add("merhaba");
            alist.Add(true);                     // farklı veri tipine örnek bool ekledik.
            int[] dizi = new int[] { 1, 2, 3, 4, 5, };    // tamsayıların odluğu bir diziyi addlist yöntemi ile ekledik.
            alist.Add(dizi);                      // diziyi eklemiş olduk.
            alist.AddRange(dizi);                 // dizi adlı yeni diziyi üstteki alist.add gibi listele-listelemeye yarar
            alist.Insert(2, "bu yeni eklenen eleman"); //listede araya eleman ekler 0 dan başlar (0,1,2), listede 3.sıraya ekler "12.45-12" arası
            string[] mdizi = new string[] { "ocak", "şubat", "mart", "nisan" };
            alist.InsertRange(4, mdizi);                //listede "12-12.5" arasına koyar. 4.boşluğa-5.sıraya ekler (0,1,2,3,4).

            for (int i = 0; i<alist.Count; i++)   // alist.count a list uzunluğundaki elemanları al ve 0 dan başlayarak birer birer arttır-Array list yazdrıması da böyle.
            {
                Console.WriteLine(alist[i]);
            }

            bool cevap = alist.Contains("Mazda");    // Contains operatörü bize listemizde "Mazda" kelimesi var mı yok mu onu belirtir. true flase cevap olur.
            Console.WriteLine(cevap);                // false

            int y = alist.IndexOf("mazda");           // bu listede "mazda" Kaçıncı sırada odluğu söyler yoksa ise -1 değeri verir.
            int a = alist.IndexOf("ocak");            // "ocak" kaçıncı sırada olduğunu gösterir. 3
            Console.WriteLine(y + a);
            Console.ReadKey();
            alist.Remove("ocak");                     //ocak indisini listeden kaldır- birden fazla "ocak varsa sadece 1 tanesini siler.
            alist.RemoveAt(1);                        // 1 numaralı indisi sil (0,1) 2.elemanı sil. Hem listeden kladırır hemde.
            alist.RemoveRange(3, 4);                  // 3 dahil olmak üzere 4 tane eleman kaldır.
            alist.Sort();                             // alfabetik olarak sıralar yada numerik olarak.
            alist.Reverse();                          // listeyi sıralamayı tersten yazar. altına for döngüsü aç

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            Hashtable ht = new Hashtable();               // Anahtar-Kilit uyumu vardır array gibidir lakin her değerin 1 eşi vardır. using system.collection.generic kullanır.
            ht.Add("22113017", "Berke Balcıoğlu");
            ht.Add("1923", "Cumuhuriyetin ilanı");         // aynı değeri iki kere girersek anahar-kilit uyumu olmaz hata verir her değerin bir karşılığı vardır. 
            ht.Add("1919", "Samsuna çıkış");
            foreach (object x in ht.Keys) ;                 //Foreach ile bütün nesnelerin üzerinde tek seferde aynı işlem yapılır. For ile her nesnede ayrı işlem yapılır.
            {
                Console.WriteLine(ht.[x]);                                  // hastableda ki objeleri x diye anlamlandırıp x kısımnına gelen value kısmındaki isimleri ekrana yazdırır
                Console.WriteLine(ht["22113017"]);
            }
            Console.ReadKey();











        }
    }
}
