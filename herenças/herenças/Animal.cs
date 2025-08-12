using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenças
{
    internal class Animal : SerVivo
    {

        public int Tamanho { get; set; }
        
        public void Mover() => Console.WriteLine("Movendo-se...");
        public void Dormir() => Console.WriteLine("Dormindo...");
        public void Respirar() => Console.WriteLine("Respirando...");
    }
}
