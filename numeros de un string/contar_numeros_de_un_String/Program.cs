using System.Text.RegularExpressions;
string texto = "skjfks¿'41fgdñkls7ddñf--s5sdf2";

string patrones = @"[0-9]";
var regex = new Regex(patrones);
int n = regex.Matches(texto).Count;

Console.WriteLine("hay "+n+ " numeros");


