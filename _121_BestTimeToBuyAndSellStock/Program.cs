
var result = MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
result = MaxProfit(new int[] { 7, 6, 4, 3, 1 });
result = MaxProfit(new int[] { 2, 4, 1 });

int MaxProfit(int[] prices)
{
    int minPrice = int.MaxValue;
    int maxProfit = 0;

    for (var i = 0; i < prices.Length; i++)
    {
        minPrice = Math.Min(prices[i], minPrice);
        maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
    }

    return maxProfit;
}