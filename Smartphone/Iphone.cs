using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_celular_C_.Smarphone
{
    public class Iphone : Phone
    {
        public string Marca;
        public void MarcaCelular()
        {
            Console.WriteLine("Smartphone Iphone:");
        }
        public override void InstalarAplicativo(string nome){ 
            Console.WriteLine($"Instalando Aplicativo {nome} no Iphonne"); 
        }
    }
}