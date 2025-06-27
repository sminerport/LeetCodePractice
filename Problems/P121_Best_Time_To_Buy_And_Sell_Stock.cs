namespace Problems;

/// <summary>
/// Provides methods to calculate the maximum profit that can be achieved by buying and selling a stock on different
/// days.
/// </summary>
/// <remarks>This class contains algorithms for solving the "Best Time to Buy and Sell Stock" problem. It includes
/// methods with varying time complexities to suit different performance requirements. Use this class to analyze stock
/// prices and determine the optimal buy and sell days for maximum profit.</remarks>
public class P121_Best_Time_To_Buy_And_Sell_Stock
{
    /// <summary>
    /// Calculates the maximum profit that can be achieved by buying and selling a stock on different days.
    /// </summary>
    /// <remarks>This method uses a brute-force approach to evaluate all possible pairs of buy and sell days.
    /// It iterates through the array to find the largest difference between a later sell price and an earlier buy
    /// price. Note that this approach has a time complexity of O(n^2), which may be inefficient for large input
    /// arrays.</remarks>
    /// <param name="prices">An array of integers representing the stock prices on consecutive days. Each element corresponds to the price of
    /// the stock on a specific day.</param>
    /// <returns>The maximum profit that can be achieved. Returns 0 if no profit is possible (e.g., if prices are in descending
    /// order or the array is empty).</returns>
    public int MaxProfit_BruteForce(int[] prices)
    {
        int largestDifference = 0;

        for (int buyDay = 0; buyDay < prices.Length; buyDay++)
        {
            for (int sellDay = buyDay + 1; sellDay < prices.Length; sellDay++)
            {
                int currentDifference = prices[sellDay] - prices[buyDay];

                if (currentDifference > largestDifference)
                {
                    largestDifference = currentDifference;
                }
            }
        }

        return largestDifference;
    }

    /// <summary>
    /// Calculates the maximum profit that can be achieved from a single buy-and-sell transaction given an array of
    /// stock prices.
    /// </summary>
    /// <remarks>This method assumes that the stock must be bought before it is sold, and the transaction can
    /// only occur once. The algorithm runs in O(n) time complexity, making it efficient for large input
    /// arrays.</remarks>
    /// <param name="prices">An array of integers representing the stock prices on consecutive days. Each element corresponds to the price of
    /// the stock on a specific day.</param>
    /// <returns>The maximum profit that can be achieved from a single buy-and-sell transaction. Returns 0 if no profit can be
    /// made (e.g., if prices are decreasing or the array is empty).</returns>
    public int MaxProfit_OnePass(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else if (prices[i] - minPrice > maxProfit)
            {
                maxProfit = prices[i] - minPrice;
            }
        }

        return maxProfit;
    }
}