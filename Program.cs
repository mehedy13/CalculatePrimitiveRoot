using System;
using System.Collections.Generic;
using System.Numerics;
 
namespace PrimitiveRoot
{
    
    class Program
    {
        static void Root(int p)
        {
            int z = p - 1;
            BigInteger [,] r = new BigInteger[z, z];
            for(int i=0;i<z;i++)
            {
                for(int j=0;j<z;j++)
                {
                    r[i, j] =(BigInteger) Math.Pow(i + 1, j + 1);
                    r[i,j]%=p;
                }
             }
            HashSet<BigInteger> s = new HashSet<BigInteger>();
            for(int i=0;i<z;i++)
            {   
                for(int k=0;k<z;k++){
                    s.Add(r[i,k]);
                }
 
               if(s.Count == z){
                    Console.Write("Primitive root : " + (i + 1) );
                    Console.WriteLine();
               }
                s.Clear();
            }
        }
        
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a prime number");
            n = Convert.ToInt32(Console.ReadLine());
            Root(n);
            Console.ReadLine();
        }
    }
 
}