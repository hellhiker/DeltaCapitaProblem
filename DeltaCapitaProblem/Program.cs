using System;
using System.Runtime.InteropServices;
using System.Linq;

public class PriceCalculation
{
    

    public static void Main(string[] args)
    {
        int totalCost=0;
        //Creating the List which matchs primary condition as given in problem 
        List<string> list = new List<string>() {"Apple","Banana","Apple","Banana","Melon","Melon", "Lime", "Lime", "Lime" };

        //storing values according to the price 

        Dictionary<string, int> itemsPrice = new Dictionary<string, int>()
        {

            {"Apple",35},
            { "Banana",20},
            {"Melon",50 },
            {"Lime",15 }
        };

        // Discounted offer on selected items

        Dictionary<string, Tuple<int, int>> DiscountedOffer = new Dictionary<string, Tuple<int, int>>()
        {
            {"Melon",Tuple.Create(1,1) },    //Meelons Values will be set to 25p each
            {"Lime",Tuple.Create(3,2) }     //Limes Values will be set to 10p each
        };

        foreach (var item in list)
        {
            if (itemsPrice.ContainsKey(item))
            {
                if (DiscountedOffer.ContainsKey(item))
                {
                    var offer = DiscountedOffer[item];
                    int itemCount = list.Count(i => i == item);
                    int discountedItems = itemCount / offer.Item1 * offer.Item2;
                    totalCost += (itemCount - discountedItems) * itemsPrice[item];
                }
                else
                {
                    totalCost += itemsPrice[item];
                    
                }
            }
            

        }
                 Console.WriteLine("Total Cost : " + totalCost +"p");
    }
}