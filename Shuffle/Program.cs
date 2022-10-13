// See https://aka.ms/new-console-template for more information
using Shuffle;

int[] arr = new int[52];
for(int i = 0; i < arr.Length; i++)
{
    arr[i] = i+1;
}


Cards.ShuffleCards(ref arr);

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}