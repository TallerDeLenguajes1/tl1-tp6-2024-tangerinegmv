// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
int num;
num = 123;
Console.WriteLine(num);
int aux = 0;
if(num != 0){
    while (num>0)
    {
        aux = num%10;
        Console.Write(aux);
        num=num/10;
    }
    
    }

/*CALCULADORA ------------*/
do
{
    Console.WriteLine('Elija una operacion:');
    Console.WriteLine('a. Suma');
    Console.WriteLine('b. Resta');
    Console.WriteLine('c. Multiplicar');
    Console.WriteLine('d. Dividir');
    Console.WriteLine('e. Salir');
    string opcion = Console.ReadLine();

    bool salir = true;
    Console.WriteLine('Ingrese el primer numero:');

    int a = int.TryParse(Console.ReadLine(), out a)

    Console.WriteLine('Ingrese el segundo numero:');
    int b = int.TryParse(Console.ReadLine(), out b);

    switch (opcion)
    {
    case 'a':
        Console.WriteLine(a+b);
        break;
    case 'b':
        Console.WriteLine(a-b);
        break;
    case 'c':
        Console.WriteLine(a*b);
        break;
    case 'd':
        Console.WriteLine(a/b);
        break;

        default:
            salir = false;
            break;
    }
   


} while (salir);
