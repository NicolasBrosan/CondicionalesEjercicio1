const int passWord = 12345678;
Console.WriteLine("###### BIENVENIDO######");
Console.Write("Por favor, ingrese la password: ");
var passUsuario = int.TryParse(Console.ReadLine(), out int num);

//Realizo la verificacion con el condicional If - Else!

if (num == passWord)
{
    Console.WriteLine("Bienvenido/a!!!");
}
else
{
    Console.WriteLine("Error en password. Por favor, volver a intentar!");  
}

//Segundo intento.

Console.Write("Por favor, ingrese la password: ");
var passUsuario2 = int.TryParse(Console.ReadLine(), out int num2);

if(num2 == passWord)
{
    Console.WriteLine("Bienvenido/a!!!");
}
else
{
    Console.WriteLine("Error en password. Finaliza el sistema. Saludos!");
}
//Fin del programa.