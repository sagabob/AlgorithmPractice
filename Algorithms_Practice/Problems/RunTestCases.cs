using Algorithms_Practice.Problems.DP.Medium;

namespace Algorithms_Practice.Problems;

public static class RunTestCases
{
    public static void Execute()
    {
       int[] balances = new int[] {77367, 85558, 88570, 98242, 46552, 2772, 64226, 72128, 15176, 93254 };
       string[] requests = new string[]
       {
           "deposit 11 6",
           "transfer 2 6 91",
           "deposit 10 58",
           "transfer 5 3 49",
           "withdraw 8 40",
           "withdraw 6 67",
           "transfer 7 6 44",
           "withdraw 5 7",
           "transfer 8 2 20",
           "transfer 9 2 94"
       };

       var output = Algorithms_Practice.Problems.DP.Medium.Prob01.solution(balances, requests);
       
        Console.WriteLine(output);
    }
}