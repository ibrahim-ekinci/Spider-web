using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            string[] kyol = new string[8];
            string[] yol=new string[8];
            int enUzun = 0;
            int enKisa = 9999;
            int olasilikSayac = 0;
            int sayac = 2;
            void bul(int[,] mydizi,int satir)
            {
                for (int i = 0; i < 21; i++)
                {
                    if (mydizi[satir, i] == 1)
                    {
                        sayac++;
                        string yazdir = satir + "-inci satır / " + i + "-inci stun";
                        Console.Write(yazdir);
                        yol[sayac-2] = yazdir;
                        if(satir == 0)
                        {
                            sayac = 2;
                        }
                        Console.WriteLine();

                        bul(mydizi, i);
                        sayac--;
                        
                    }
                    else if (mydizi[satir, i] == 2)
                    {
                        satir = 0;
                        olasilikSayac++;
                        Console.Write("-->***geldi sayac ="+(sayac) );
                        Console.WriteLine();
                        Console.WriteLine("-------------------------------");
                        if(sayac>enUzun)
                        {
                            enUzun = sayac;
                        }
                        if (sayac<enKisa)
                        {
                            enKisa = sayac;
                            for (int j = 0; j < 8; j++)
                            {
                                kyol[j] = yol[j];
                            }
                        }
                    }
                }
            }
            



            /* */
            int[,] dizi = new int[21, 21] 
            {        // 0, 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11,12,13,14,15,16,17,18,19,20
             /*0 */   { 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
             /*1 */   { 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
             /*2 */   { 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
             /*3 */   { 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
             /*4 */   { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
             /*5 */   { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0},
             /*6 */   { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
             /*7 */   { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
             /*8 */   { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0},
             /*9 */   { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
             /*10*/   { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
             /*11*/   { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
             /*12*/   { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1, 1, 1, 0, 0},
             /*13*/   { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0},
             /*14*/   { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
             /*15*/   { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2},
             /*16*/   { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0},
             /*17*/   { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2},
             /*18*/   { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0},
             /*19*/   { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2},
             /*20*/   { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                       
            };
           
            bul(dizi,0);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("Olasılık sayısı :" + olasilikSayac);
            Console.WriteLine("En kısa yol Basamak sayısı :" + enKisa);
            Console.WriteLine("En uzun yol Basamak sayısı :" + enUzun);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("En Kısa Yol :");
            string son="";
            for (int i = 0; i < enKisa-1; i++)
            {
                Console.WriteLine(kyol[i]);
                son = kyol[i].Substring(kyol[i].Length-12, 2);
            }
            if (son=="15")
            {
                Console.WriteLine("15-inci satır / 20-inci stun");
            }
            else if (son == "17")
            {
                Console.WriteLine("17-inci satır / 20-inci stun");
            }
            else if (son == "19")
            {
                Console.WriteLine("19-inci satır / 20-inci stun");
            }
            
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.ReadKey();
        }
    }
}
