//conteo de palabras
using System.Text.RegularExpressions;

string oracion = " hola amigo como estan   ?      ";
int numero_palabras = 0;

oracion = Regex.Replace(oracion,@"\s+"," ").Trim();
var trend = oracion.Split(' ');
numero_palabras = trend.Length;

Console.WriteLine("el numero de palabras es de "+numero_palabras);
