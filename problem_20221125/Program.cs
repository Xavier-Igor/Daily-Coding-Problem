int [] arr = { 1, 2, 3, 4, 5 };
int[] numeros = new int [arr.Length] ;
int mult = 1;
for (int i = 0;i < arr.Length; i++)
{
    mult = mult * arr[i];
}

for (int i = 0; i < arr.Length;)
{
    int soma = arr[i];
    int count = 1;
    while(soma < mult)
    {
        soma += arr[i];
        count++;
    }
    numeros[i] = count;
    i++;
}

foreach (int i in numeros)
{
    Console.WriteLine(i);
}


