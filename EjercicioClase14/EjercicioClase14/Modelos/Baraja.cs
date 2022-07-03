using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase14.Modelos
{
    public class Baraja
    {
        Carta[] cartas;
        public int posSiguienteCarta;
        public Baraja(){
            cartas = new Carta[40];
            posSiguienteCarta = 0;
            crearBaraja();
        }
        public void crearBaraja()
        {
            string[] palos = Carta.palos;
            for (int i = 0; i < palos.Length; i++)
            {
                for (int j = 0; j < Carta.Limite_Carta_Palo; j++)
                {
                    if (!(j ==7 || j == 8))
                    {
                        if (j>=9)
                        {
                            cartas[(i * (Carta.Limite_Carta_Palo - 2)) + (j-2)] = new Carta(j + 1, palos[i]);
                        }
                        else
                        {
                            cartas[(i * (Carta.Limite_Carta_Palo - 2)) + j] = new Carta(j+1, palos[i]);
                        }
                    }
                }
            }
        }

        public void barajar()
        {
            Random rnd = new Random();
            for (int i = 0; i < cartas.Length; i++)
            {
                int posicion = rnd.Next(0,cartas.Length);
                Carta aux = cartas[i];
                cartas[i] = cartas[posicion];
                cartas[posicion] = aux;
            }
            posSiguienteCarta = 0;
        }
        public Carta siguienteCarta()
        {
            Carta c = null;
            if (posSiguienteCarta < cartas.Length)
            {
                c = cartas[posSiguienteCarta++];
                return c;
            }
            else
            {
                Console.WriteLine("Ya no hay más cartas, baraje de nuevo");
                return c;
            }
        }
        public Carta[] darCartas(int numCartas)
        {
            if (numCartas > cartas.Length)
            {
                Console.WriteLine("No hay suficientes cartas. Solo 40 cartas");
                return null;
            } 
            else
            {
                if (cartasDisponibles() < numCartas)
                {
                    Console.WriteLine("No hay suficientes cartas");
                    return null;
                }
                else
                {
                    Carta[] cartasDar = new Carta[numCartas];
                    for (int i = 0; i < cartasDar.Length; i++)
                    {
                        cartasDar[i] = this.siguienteCarta();
                    }
                    return cartasDar;
                }
            }
        }
        public int cartasDisponibles()
        {
            return cartas.Length - posSiguienteCarta;
        }
        public void cartasMonton()
        {
            if (cartasDisponibles() == cartas.Length)
            {
                Console.WriteLine("No hay cartas jugadas");
            }
            else
            {
                for (int i = 0; i < posSiguienteCarta; i++)
                {
                    Console.WriteLine($"Carta -> Numero: {cartas[i].Numero} Tipo: {cartas[i].Palo}");
                }
            }
        }
        public void mostrarBaraja()
        {
            if (cartasDisponibles() == 0)
            {
                Console.WriteLine("No hay cartas en la baraja");
            }
            else
            {
                for (int i = posSiguienteCarta; i < cartas.Length; i++)
                {
                    Console.WriteLine($"Carta -> Numero: {cartas[i].Numero} Tipo: {cartas[i].Palo}");
                }
            }
        }
    }
}
