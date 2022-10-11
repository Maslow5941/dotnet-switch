// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch(letra){

case "a":
case "e":
case "i":
case "o":
case "u":

Console.WriteLine("Vogal");
break;

default:
Console.WriteLine("não é uma vogal");
break;




}