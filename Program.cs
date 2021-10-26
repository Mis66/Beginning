using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginning
{
    class Program
    {
        static void Main(string[] args)
        {

            #region indirimli fiyat hesaplama
            //decimal indirim = 10.20m;
            //decimal price = 5m;
            //decimal indirimliFiyat = price - (indirim * price);
            //Console.WriteLine("indirimli Fiyat:" + indirimliFiyat);
            //Console.ReadLine();
            #endregion

            #region Stringli Ornek classli
            //StringBuilder builder = new StringBuilder();
            //string ad = "Fatma";
            //string soyad = "Atila";
            //builder.Append("Ad:" + ad);
            //builder.Append(Environment.NewLine);
            //builder.Append("Soyad:" + soyad);
            //Console.WriteLine(builder.ToString());
            //Console.ReadLine();
            #endregion

            #region Kullanicinin Girmesi icin
            // Console.WriteLine("Adiniz:");
            //string ad = Console.ReadLine();
            // Console.WriteLine("Soyadiniz:");
            //string soyad = Console.ReadLine();
            #endregion

            #region CONSTRANT SABIT KULLANIMI
            //const double pi = 3.1415;
            //double alan, cevre, yaricapi;
            //string yaricapiGirilen;
            //Console.WriteLine("Dairenin Yaricapi:");
            //yaricapiGirilen = Console.ReadLine();
            //yaricapi = Convert.ToDouble(yaricapiGirilen);
            //cevre = 2 * pi * yaricapi;
            //alan = pi * Math.Pow(yaricapi , 2);
            //Console.WriteLine("Dairenin Alani:{0}", alan);
            //Console.WriteLine("Cevrenin Alani:{0}", cevre);
            //Console.ReadLine();
            #endregion

            //VAR TÜRÜNÜ KULLANIRKEN EŞİTLEDİĞİN DEGERIN TÜRÜNÜ ALIR VAR SAYI=7 DERSEN VAR INT OLUR.
            #region REF VE OUT:C# içerisinde yer alan ref ve out değer türündeki verileri referans olarak metotlara geçmek için kullanılan anahtar kelimelerdir.
            //C# veri türleri temel olarak değer ve referans olmak üzere ikiye ayrılır.
            //ref ve out anahtar kelimeleri aynı işlemi yapar.
            // Değer türleri(int, double, float, char .vb) belleğin stack bölgesinde tutulur.
            // Referans türleri(string, diziler, object, nesneler) belleğin heap bölgesinde tutulur.
            // Değer türleri referans türlerine göre daha hızlı çalışır ancak belleğin stack alanı sınırlı olduğu için diziler, nesneler belleğin heap bölgesinde oluşturulur.
            // Heap bölgesinde oluşturulan referans türlerine belleğin başlangıç adresi ile erişim sağlanır ve herhangi bir yerde yapılan değişiklik verinin değişmesine neden olur.


            //int sayimizOut;
            //DegistirOut(out sayimizOut);
            //Console.WriteLine(sayimizOut);

            //int sayimizRef = 0;  // değer verilmediğinde hata verecektir.
            //DegistirRef(ref sayimizRef);
            //Console.WriteLine(sayimizRef);

            //Console.ReadLine();



            #endregion



            #region Arttirma
            //int x = 10;
            //int sonuc = ++x;
            //Console.WriteLine("X:{0}", sonuc);
            //Console.ReadLine();
            #endregion
            #region Switch(Egerki birden fazla ihtimal var ise kullanmak daha mantikli.Orn:case1:case2:case3: Console.WriteLine("Uc"); burada sayi 1,2 veya 3 olursa uc yazilacak)

            //int sayi = Convert.ToInt32(Console.ReadLine());
            //switch (sayi)
            //{
            //    case 1:
            //        Console.WriteLine("Bir");
            //        break;

            //    case 4:
            //        Console.WriteLine("Dort");
            //        break;
            //    default: Console.WriteLine("Tanimlanamadi");
            //        break;

            //}
            //Console.ReadLine();

            #endregion

            #region DIZILER Arrays genellıkle hafızada tutma işlemidir.Bircok fonksiyonu var.Listler filan...

            //int[] dizi = new int [12];
            //dizi[0] = 1;
            //dizi[1] = 5;
            //Console.WriteLine("Dizi:" +dizi[1]);
            //Console.ReadLine();

            //int[] deneme = new int[3];
            //deneme[0] = 5;
            //deneme[1] = deneme[0] * 2;
            //deneme[2] = deneme[1] * 2;
            //Console.WriteLine("Carpim Sonucu:"+deneme[1]);

            //int[] dizi = new int[3];
            //dizi[0] = 5;

            //for (int i = 0; i <dizi.Length ; i++) burada lenht verilme nedeni her zaman icerideki sayiyi bilmiyoruz/
           // icerdeki kume sayisi kadar demektir/''
            //{
            //    dizi[i] = (i - 1) * 2;
            //}
            //Console.WriteLine("Carpim Sonucu:"+dizi[2]);



            //Console.ReadLine();
            #endregion

            #region FOR

            //for (int i = 1; i <7; i++)

            //{
            //    Console.WriteLine("fatma");
            //}

            //int sonuc = 0;
            //for (int i = 0;  i<=3; i++)
            //{
            //    sonuc += i;
            //    Console.WriteLine(sonuc);
            //}

            //int bolunebilen =0;
            //int bolunemeyen =0 ;

            //for (int i = 1; i <=20; i++)
            //{
            //    if (i%5==0)
            //    {
            //        Console.WriteLine("Bolunebilen"+i);
            //        bolunebilen++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bolunemeyen"+i);
            //        bolunemeyen++;
            //    }
            //}
            //Console.WriteLine("Bolunebilen:"+bolunebilen++);
            //Console.WriteLine("Bolunemeyen:"+bolunemeyen++);

            #endregion

            #region Carpim Tablosu


            //int sonuc = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int f = 1; f <= 10; ++f)
            //    {
            //        sonuc = f * i;
            //        //Console.WriteLine("{0}X{1}={2}",i,f,i*f);
            //        Console.WriteLine(sonuc);
            //    }
            //    Console.WriteLine("\n");
            //}



            #endregion

            //   int i = 0;
            //  i++;
            //// ++i;
            //   Console.WriteLine(i);

            //   int f = 1;
            //   f++;
            //   Console.WriteLine(f);


            //int not;
            //Console.WriteLine("Notunuzu giriniz:");
            //not = Console.Read();

            #region DO WHILE  Kosul dogru olmasada 1 kez iceri girer whiledan farki bu.


            //string sifre = string.Empty;

            //int counter = 0;

            //do
            //{

            //    Console.Write("Sifre giriniz:");
            //    sifre = Console.ReadLine();

            //    if (sifre=="12345")
            //    {
            //        Console.WriteLine("Sifreyi Dogru Girdiniz");
            //        break;
            //    }
            //    counter++;
            //    if (counter>=3)
            //    {
            //        Console.WriteLine("3 hatali giris yapilmistir!!!");
            //        break;

            //    }


            //} while (sifre !="12345");
            #endregion




            #region FOREACH Dizileri tek tek dolasmaya yarar.

            //string[] dizi = { "Fatma", "Kadir", "Arife", "Resul" };

            //foreach (var isim in dizi)
            //{

            //    Console.WriteLine(isim);

            //}
            #endregion


            #region ADDRANGE:LISTELERI BIRLESTIRMEK ICIN KULLANILIR.

            ArrayList liste1 = new ArrayList();
            ArrayList liste2 = new ArrayList();

            liste1.Add("Pazartesi");
            liste1.Add("Sali");
            liste1.Add("Carsamba");
            liste1.Add("Persembe");
            liste1.Add("Cuma");
            liste1.Add("Cumartesi");
            liste1.Add("Pazar");

       
            liste2.Add("Sonbahar");
            liste2.Add("Yaz");
            liste2.Add("Kis");

            liste1.AddRange(liste2);
           

            foreach (var item in liste1)
            {
                Console.WriteLine(item);
            }
            #endregion

     


            Console.ReadLine();


        }
        public static void DegistirRef(ref int sayiRef)
        {
            sayiRef = 1234;
        }

        public static void DegistirOut(out int sayiOut)
        {
            sayiOut = 1234;
        }

        

    }
}
