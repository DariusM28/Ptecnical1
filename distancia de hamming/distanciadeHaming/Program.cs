// distancia de hamming
string text1 = "patitosw", text2 = "partcosa";
int distancia = 0;  
if (text1.Length != text2.Length) {
    throw new Exception("no tienen la misma logitud");
}

for (int i = 0; i < text1.Length; i++) {

    if (text1[i] != text2[i]) { 
    distancia++;    
    }

}    
Console.WriteLine("la distancia es de "+distancia);