using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Hash_Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table Demo");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);


            hash.Add("0", "To");

            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            Console.WriteLine("frequency of word is "+ hash.GetFrequencyOfWords("be") ); 


            

            /*string[] myArr = new string[100];
            hash.toArray(myArr);
            foreach(string str in myArr)
            {
                Console.WriteLine(str);
            }*/

          //  hash.occurence("be");

            /*for (String temp : hash)
{
                Console.WriteLine(temp + ": " + Collections.frequency(List, temp));
            }*/
            //Console.WriteLine( hash.Count_Word_Occurrences("be"));

            // string[] splt = hash.split();
            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value : "+hash5);
            //Console.WriteLine(hash5.);

            string hash2 = hash.Get("2");
            Console.WriteLine("2nd index value : " + hash2);

           

            MyMapNode<string, string> hashParanoid = new MyMapNode<string, string>(18);
            hashParanoid.Add("0", "Paranoids");
            hashParanoid.Add("1", "are");
            hashParanoid.Add("2", "not");
            hashParanoid.Add("3", "paranoids");
            hashParanoid.Add("4", "because");
            hashParanoid.Add("5", "they");
            hashParanoid.Add("6", "are");
            hashParanoid.Add("7", "paranoid");
            hashParanoid.Add("8", "but");
            hashParanoid.Add("9", "they");
            hashParanoid.Add("10", "keep");
            hashParanoid.Add("11", "putting");
            hashParanoid.Add("12", "themselves");
            hashParanoid.Add("13", "deliberately");
            hashParanoid.Add("14", "into");
            hashParanoid.Add("15", "paranoid");
            hashParanoid.Add("16", "avoidable");
            hashParanoid.Add("17", "situations");

            for (var i = 0; i < 18; i++)
            {

                string sentence = hashParanoid.Get(i.ToString());
                Console.Write(sentence + " ");

            }

           /*var sentence1 = hashParanoid;
      
            for (var o = 0; o < 180; o++)
            {
                if (sentence1 == " ")
                {
                    o = o + 1;
                }
                Console.Write("Array :" + sentence1[o]);
            }*/
            



            hashParanoid.Remove("16");

            Console.WriteLine("\n After removing avoidalble ");

            for (var i = 0; i < 18; i++)
            {

                string sentence = hashParanoid.Get(i.ToString());
                if (sentence == null)
                {
                    sentence = hashParanoid.Get(i + 1.ToString());
                }
                Console.Write(sentence + " ");

            }
            
            
/*            Console.WriteLine("Enter the word whose frequency you wantto search");
            string x = Console.ReadLine();

            for (var i = 0; i < 18; i++)
            {

                string sentence = hashParanoid.Get(i.ToString());
                int count = hashParanoid.items.Count;
                int Count = count;
                //var frequency = sentence.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            }
            Console.WriteLine(Count);*/




        }
    }
}
