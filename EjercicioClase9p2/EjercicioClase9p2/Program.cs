/*
 * 1)    Cartón de 3 filas por 9 columnas
   2)    El cartón debe tener 15 números y 12 espacios en blanco
   3)    Cada fila debe tener 5 números
   4)    Cada columna debe tener 1 o 2 números
   5)    Ningún número puede repetirse
   6)    La primer columna contiene los números del 1 al 9, 
var randomNumber = new Random().Next(0, 100);dEVUELVE ENTRE 0 Y 99
    la segunda del 10 al 19, la tercera del 20 al 29, así sucesivamente 
    hasta la última columna la cual contiene del 80 al 90
   7)    Mostrar el carton por pantalla*/
// valor de la coumna

var resp = "S";
//Nro de columna
int valorCol = 9;

//Nro de filas
int valorFil = 3;

//Declaracion de la Matriz
int[,] carton = new int[valorFil, valorCol];

int[] espacios = new int[9];
Random aleatorio = new Random();
while (resp.ToUpper() != "N")
{
    var acumulador = 0;
    while (true)
    {
        acumulador = 0;
        for (int i = 0; i < espacios.Length; i++)
        {
            espacios[i] = aleatorio.Next(1, 3);
            acumulador = acumulador + espacios[i];
        }
        if (acumulador == 12)
        {
            break;
        }
    }

    /*Para saber las dimensiones de la matriz*/
    //cantidad de filas 
    int lengthFilas = carton.GetUpperBound(0) + 1;

    //cantidad de columnas
    int lengthColumnas = carton.GetUpperBound(1) + 1;

    var val = 9;
    bool band;
    bool band1;
    var auxiliar = 0;

    int valorFilEsp = 0;
    int valorFilEsp1 = 0;

    //Cargamos
    for (int col = 0; col < lengthColumnas; col++)
    {
        //Recorremos filas
        band = true;
        band1 = true;
        for (int fil = 0; fil < lengthFilas; fil++)
        {
            if (espacios[col] == 1)
            {
                if (band)
                {
                    valorFilEsp = aleatorio.Next(0, 3);
                    band = false;
                }
                if (valorFilEsp == fil)
                {
                    carton[fil, col] = 0;
                }
                else
                {
                    carton[fil, col] = aleatorio.Next(((col + 1) * 10) - val, ((col + 1) * 10));
                }

            }
            else
            {
                if (band1)
                {
                    valorFilEsp = aleatorio.Next(fil, 3);
                    do
                    {
                        valorFilEsp1 = aleatorio.Next(fil, 3);
                    } while (valorFilEsp == valorFilEsp1);
                    band1 = false;
                }

                if (valorFilEsp == fil || valorFilEsp1 == fil)
                {
                    carton[fil, col] = 0;
                }
                else
                {
                    carton[fil, col] = aleatorio.Next(((col + 1) * 10) - val, ((col + 1) * 10));
                }
            }
        }
        if (band1)
        {
            if (valorFilEsp == 0)
            {
                if (carton[1, col] == carton[2, col])
                {
                    do
                    {
                        carton[2, col] = aleatorio.Next(((col + 1) * 10) - val, ((col + 1) * 10));
                    } while (carton[1, col] == carton[2, col]);
                }
                if (carton[1, col] > carton[2, col])
                {
                    auxiliar = carton[1, col];
                    carton[1, col] = carton[2, col];
                    carton[2, col] = auxiliar;
                }
            }
            else if (valorFilEsp == 1)
            {
                if (carton[0, col] == carton[2, col])
                {
                    do
                    {
                        carton[2, col] = aleatorio.Next(((col + 1) * 10) - val, ((col + 1) * 10));
                    } while (carton[0, col] == carton[2, col]);
                }
                if (carton[0, col] > carton[2, col])
                {
                    auxiliar = carton[0, col];
                    carton[0, col] = carton[2, col];
                    carton[2, col] = auxiliar;
                }
            }
            else
            {
                if (carton[0, col] == carton[1, col])
                {
                    do
                    {
                        carton[1, col] = aleatorio.Next(((col + 1) * 10) - val, ((col + 1) * 10));
                    } while (carton[0, col] == carton[1, col]);
                }
                if (carton[0, col] > carton[1, col])
                {
                    auxiliar = carton[0, col];
                    carton[0, col] = carton[1, col];
                    carton[1, col] = auxiliar;
                }
            }
        }
        val = 10;
    }
    //Recorremos la matriz
    string valorImp = "  ";
    for (int f = 0; f < lengthFilas; f++)
    {

        for (int c = 0; c < lengthColumnas; c++)
        {
            if (carton[f, c] == 0)
            {
                Console.Write("|  {0,-3} |", valorImp);
            }
            else
            {
                Console.Write("|  {0,-3} |", carton[f, c]);
            }
        }
        Console.WriteLine();
    }

    Console.WriteLine("Otro Carton? S/N");
    resp = Console.ReadLine();
}
