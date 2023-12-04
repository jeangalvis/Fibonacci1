Console.Write("Ingrese n: ");
int valor = Convert.ToInt32(Console.ReadLine());
int temporal1 = 0;
int temporal2 = 1;
for(int i = 1; i<valor; i++){
    int suma = temporal1 + temporal2;
    temporal1 = temporal2;
    temporal2 = suma;
}
Console.WriteLine(temporal2);