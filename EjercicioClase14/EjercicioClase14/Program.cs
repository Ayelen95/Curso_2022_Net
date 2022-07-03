using EjercicioClase14.Modelos;
// CREAMOS BARAJA
Baraja MiBaraja = new Baraja();
/*MiBaraja.barajar();
MiBaraja.mostrarBaraja();
Console.WriteLine("Siguiente Carta");
MiBaraja.siguienteCarta();
Console.WriteLine("Mostrar Baraja");
MiBaraja.mostrarBaraja();
Console.WriteLine("Dar cartas");
MiBaraja.darCartas(45);
Console.WriteLine("Dar cartas");
MiBaraja.darCartas(1);
Console.WriteLine("CARTAS DISPONIBLES");
Console.WriteLine(MiBaraja.cartasDisponibles()); 
Console.WriteLine("CARTAS MONTON");
MiBaraja.cartasMonton();
Console.WriteLine("MOSTRAR BARAJA");
MiBaraja.mostrarBaraja();
*/


bool salir = false;
while (!salir)
{
    Console.Clear();
    Console.WriteLine("******************************");
    Console.WriteLine("* 1. Barajar                 *");
    Console.WriteLine("* 2. Siguiente Carta         *");
    Console.WriteLine("* 3. Cartas Disponibles      *");
    Console.WriteLine("* 4. Dar Cartas              *");//parametro int
    Console.WriteLine("* 5. Cartas Monton           *");
    Console.WriteLine("* 6. Mostrar Baraja          *");
    Console.WriteLine("* 7. Salir                   *");
    Console.WriteLine("* Elige una de las opciones  *");
    Console.WriteLine("******************************");
    int opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            //Al colocar esta opcion el juego vuelve a comenzar 
            Console.Clear();
            MiBaraja.barajar();
            Console.WriteLine("Cartas Mezcladas");
            Console.WriteLine("Presione una tecla");
            Console.ReadKey();
            break;
        case 2:
            Console.Clear();
            Carta c = MiBaraja.siguienteCarta();
            Console.WriteLine($"Carta -> Numero: {c.Numero}, Tipo: {c.Palo}");
            Console.WriteLine("Presione una tecla");
            Console.ReadKey();
            break;
        case 3:
            Console.Clear();
            Console.WriteLine($"Cantidad de Cartas Disponibles {MiBaraja.cartasDisponibles()}");
            Console.WriteLine("Presione una tecla");
            Console.ReadKey();
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("Ingrese Cantidad");
            int numCartas = Convert.ToInt32(Console.ReadLine());
            var auxBaraja = MiBaraja.darCartas(numCartas);
            if (auxBaraja is not null)
            {
                Console.WriteLine($"Se dieron {numCartas} cartas");
                for (int i = 0; i < auxBaraja.Length; i++)
                {
                    Console.WriteLine($"Carta -> Numero: {auxBaraja[i].Numero}, Tipo: {auxBaraja[i].Palo}");
                }
            }
            Console.WriteLine("Presione una tecla");
            Console.ReadKey();
            break;
        case 5:
            Console.Clear();
            MiBaraja.cartasMonton();
            Console.WriteLine("Presione una tecla");
            Console.ReadKey();
            break;
        case 6:
            Console.Clear();
            MiBaraja.mostrarBaraja();
            Console.WriteLine("Presione una tecla");
            Console.ReadKey();
            break;
        case 7:
            salir = true;
            break;
        default:
            Console.WriteLine("Elige una opcion entre 1 y 7");
            break;
    }
}
Console.WriteLine("Presione una tecla");
Console.ReadKey();