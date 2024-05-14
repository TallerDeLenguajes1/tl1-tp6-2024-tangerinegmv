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