using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    public class Order
    {
        private const int cost = 8;
        private double orderPrice = 0;

        int[] units = new int[5];
        private int[] insertOrder(int[] arr)
        {
            foreach (int i in arr)
            {
                units[i - 1] += 1;
            }
            return units;
        }

        private int minCollections(int[] arr)
        {
            var col = 0;
            for(var i=0; i<arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    //Console.WriteLine(i+" the arr val: " + arr[i]);
                    col++; 
                }
            }
            //Console.WriteLine(col);
            return col;
        }

        public double calculatePrice(int[] arr)
        {
            int[] amount = new int[5];
            insertOrder(arr);
            Array.Copy(units, amount, 5);
            //Console.WriteLine("Working");
            while (minCollections(amount)>0)
            {
            //Console.WriteLine("Working");
                //Console.WriteLine(minCollections(amount));
                switch(minCollections(amount))
                {
                    case 1:
                        for (var item = 0; item < amount.Length; item++)
                        {
                            if (amount[item] >0)
                            amount[item]--;
                        }
                        orderPrice += 8;
                        //Console.WriteLine(orderPrice);
                        break;
                    case 2:
                        for (var item = 0; item < amount.Length; item++)
                        {
                            if (amount[item] >0)
                            amount[item]--;
                        }
                        orderPrice += 2 * 8 * 0.95;
                        //Console.WriteLine(orderPrice);
                        break;
                    case 3:
                        for (var item = 0; item < amount.Length; item++)
                        {
                            if (amount[item] >0)
                            amount[item]--;
                        }
                        orderPrice += 3 * 8 * 0.9;
                        //Console.WriteLine(orderPrice);
                        break;
                    case 4:
                        for (var item = 0; item < amount.Length; item++)
                        {
                            if (amount[item] >0)
                            amount[item]=0;
                        }
                        orderPrice += 4 * 8 * 0.8;
                        //Console.WriteLine(orderPrice);
                        break;
                    case 5:
                        for (var item=0;item<amount.Length;item++)
                        {
                            if (amount[item] >0)
                                amount[item]--;
                        }
                        orderPrice += 8 * 5 * 0.75;
                        break;
                }
            }
            return orderPrice;
        }

    }
}