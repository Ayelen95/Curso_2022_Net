using EjerClass13Billetera;

////Creamos una billetera
//Billetera billetera = new Billetera();
//billetera.BilletesDe10 = 0;
//billetera.BilletesDe20 = 0;
//billetera.BilletesDe50 = 0;
//billetera.BilletesDe100 = 0;
//billetera.BilletesDe200 = 0;
//billetera.BilletesDe500 = 0;
//billetera.BilletesDe1000 = 1;

////Creamos 2da billetera
//Billetera billetera2 = new Billetera();
//billetera2.BilletesDe10 = 5;
//billetera2.BilletesDe20 = 10;
//billetera2.BilletesDe50 = 25;
//billetera2.BilletesDe100 = 50;
//billetera2.BilletesDe200 = 100;
//billetera2.BilletesDe500 = 250;
//billetera2.BilletesDe1000 = 500;
//Billeteras
Billetera[] billeteras = new Billetera[2];

billeteras[0] = new Billetera();
billeteras[1] = new Billetera();

for (int i = 0; i < billeteras.Length; i++)
{
    Console.WriteLine($"Billetera Nro {i + 1}");
    Console.WriteLine("Ingrese cantidad de Billetes de 10");
    billeteras[i].BilletesDe10 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese cantidad de Billetes de 20");
    billeteras[i].BilletesDe20 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese cantidad de Billetes de 50");
    billeteras[i].BilletesDe50 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese cantidad de Billetes de 100");
    billeteras[i].BilletesDe100 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese cantidad de Billetes de 200");
    billeteras[i].BilletesDe200 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese cantidad de Billetes de 500");
    billeteras[i].BilletesDe500 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese cantidad de Billetes de 1000");
    billeteras[i].BilletesDe1000 = int.Parse(Console.ReadLine());
}

//Mostrar total y detalle de  las billeteras 1 y 2
for (int i = 0; i < billeteras.Length; i++)
{
    Console.WriteLine($"Total de Billetera {i + 1}: " + billeteras[i].Total());
    Console.WriteLine(billeteras[i].Detalle());
}
Billetera billetera3 = billeteras[1].Combinar(billeteras[0]);

Console.WriteLine($"Total de Billetera 3: " + billetera3.Total());

Console.WriteLine(billetera3.Detalle());