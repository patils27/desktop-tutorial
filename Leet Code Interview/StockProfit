using System;
using System.Collections.Generic;

namespace InterviewQuestions
{
    public class StockProfit1
    {
        public static void Main(string[] args)
        {
            int[] prices  = new int {1,5,2,8,9}
            Console.WriteLine(StockProfit(prices));
        }

	    public static int StockProfit(int[] prices)
	    {
		    int MaxProfit = 0;

		    for(int i = 1; i < prices.Length;i++)
    		{
			if (prices[i] > prices[i-1])
			MaxProfit += prices[i] - prices[i-1];
	    	}

		    return MaxProfit;

	    }   

    }
}