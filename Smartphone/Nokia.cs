using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_celular_C_.Smarphone
{
    public class Nokia : Phone
    {
        public string Marca;
        public void MarcaCelular()
        {
            Console.WriteLine("Smartphone Nokia:");
        }
        public override void InstalarAplicativo(string nome){
            Console.WriteLine($"Instalando Aplicativo {nome} no Iphonne");
        }
    }
}