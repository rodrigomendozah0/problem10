using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double desc, impuesto, consumo, m_desc, m_alpagar;
            Console.WriteLine("RESTAURANT");
            Console.WriteLine("**********");
            Console.WriteLine("Ingrese el monto del consumo: ");
            consumo = double.Parse(Console.ReadLine());
            desc = 0.0;
            impuesto = 0.0;

            if (consumo <= 100.00)
            {
                desc = consumo * 0.10; 
            }
            else
            {
                desc = consumo * 0.20;
            }

            m_desc = consumo - desc;
            impuesto = m_desc * 0.18;

            m_alpagar = m_desc + impuesto;

            Console.WriteLine("El monto del descuento es: S/" + desc.ToString("0.00"));
            Console.WriteLine("El impuesto del consumo es: S/" + impuesto.ToString("0.00"));
            Console.WriteLine("El subtotal es: S/" + m_desc.ToString("0.00"));
            Console.WriteLine("El monto total del consumo es: S/" + m_alpagar.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
