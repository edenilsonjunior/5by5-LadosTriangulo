// 3- Faça um programa que leia os 3 lados de um triangulo e informe o tipo dele

float lado1 = 0, lado2 = 0, lado3 = 0;

Console.WriteLine("=====Tipos de Triangulo=====");

do{
    Console.Write("Digite o primeiro lado: ");
    lado1 = float.Parse(Console.ReadLine());

} while (lado1 <= 0);

do{
    Console.Write("Digite o segundo lado: ");
    lado2 = float.Parse(Console.ReadLine());

} while (lado2 <= 0);

do{
    Console.Write("Digite o terceiro lado: ");
    lado3 = float.Parse(Console.ReadLine());

} while (lado3 <= 0);


Console.WriteLine("=============================");
if (lado1 < (lado2 + lado3) && (lado2 < (lado1 + lado3)) && (lado3 < (lado1 + lado2)))
{
    if(lado1 == lado2 && lado2 == lado3)
        Console.WriteLine("Triangulo Equilátero!");
    else if((lado1 != lado2) && (lado2 != lado3) && (lado1 != lado3))
        Console.WriteLine("Triangulo Escaleno!");
    else
        Console.WriteLine("Triangulo Isosceles!");
}
else{
    Console.WriteLine("Os numeros informados NÃO formam um triangulo!");
}

Console.WriteLine("=============================");

Console.Write("\nDigite qualquer tecla para sair: ");
Console.ReadKey();