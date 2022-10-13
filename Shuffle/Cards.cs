using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle
{
    public static class Cards
    {
        public static void ShuffleCards(ref int[] arr)
        {
            Random random = new Random();   
            for(int i = 0; i<arr.Length-1; i++)
            {
                int k = random.Next(i,arr.Length);
                int val=arr[k];
                arr[k] = arr[i];
                arr[i] = val;
            }
        }
    }
}
