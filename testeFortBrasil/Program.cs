using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeFortBrasil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos telefones irá digitar? ");
            int n = int.Parse(Console.ReadLine());
            string[] telefones = new string[n];
            string telefone ="";
            for (int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + "º telefone: ");
                telefone = Console.ReadLine();
                telefones[i] = telefone;
            }

            foreach(String s in telefones)
            {
                Console.WriteLine(s);
            }

            int count =0;
            foreach(String s in telefones)
            {
                if (telefones[0].Substring(0,1) == telefones[1].Substring(0,1))
                {
                    for(int i = 1;i < telefone.Length; i++)
                    {
                        if(telefones[0].Substring(0,i) == telefones[1].Substring(0,i))
                        {
                            count++;
                        }
                    }
                }
            }
            count = count /telefones.Length;
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
