int[] arr = { 10, 15, 3, 7, 4, 5, 26 };
int k = 30;

for (int i = 0; i < arr.Length;)
{
    for (int j = 0; j < arr.Length;)
    {
        int soma = Array.IndexOf(arr, arr[i]) + arr[j];

        if (soma == k && arr[i] != arr[j])
        {
            Console.WriteLine("Posicao 1: " + arr[i] + " " + "Posicao 2: " + Array.IndexOf(arr, arr[j]));
            return;
        }
        j++;
    }
    i++;
}