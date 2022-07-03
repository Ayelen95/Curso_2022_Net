using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase14.Modelos
{
    public class Carta
    {
        public int Numero;
        public string Palo;

        public static string[] palos = { "oros", "copas", "bastos", "espadas" };
        public static int Limite_Carta_Palo = 12;
        public Carta(int Numero, string Palo)
        {
            this.Numero = Numero;
            this.Palo = Palo;
        } 
        
    }
    


}
