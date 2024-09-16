using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_celular_C_.Smarphone
{
    public abstract class Phone
    {
        public string Numero { get; set; }
        private string Modelo {get; set; }
        private string Memoria {get; set; }
    
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação.");
        }
        public abstract void InstalarAplicativo(string nome);
    }
}