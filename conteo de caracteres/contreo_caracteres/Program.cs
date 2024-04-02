string cadena = "kjdldk647sa  78skldu iekj dsahaa";
char letra = '7';
int contador = 0;
/*
for (int i = 0; i <= cadena.Length-1; i++) { 
if (cadena[i] == letra) { 
    contador++; 
    }
}*/
/*
foreach (char c in cadena) { 
if (c == letra) contador++;
}*/

contador = cadena.Where(c=>c==letra).Count();


Console.WriteLine("la letra " + letra + " se repite: " + contador + " veces.");