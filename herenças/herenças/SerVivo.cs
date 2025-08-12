using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenças
{
    internal class SerVivo
    {
        public int Tamanho { get; set; }


        public void Nascer() => Console.WriteLine("nascendo...");
        public void Crescer() => Console.WriteLine("Crescendo...");
        public void Comer() => Console.WriteLine("Comendo...");



    }
}
