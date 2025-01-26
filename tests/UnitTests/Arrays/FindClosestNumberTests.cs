using DSA.Problems.Arrays;

namespace DSA.UnitTests.Arrays;

public class FindClosestNumberTests
{
    private readonly FindClosestNumber.Solution _solution = new();

    [Theory]
    [MemberData(nameof(TestCases))]
    public void MainSolution_ShouldReturnExpectedResult(int[] input, int expected)
    {
        // act
        var result = _solution.Solve(input);

        // assert
        Assert.Equal(expected, result);
    }
    
    public static IEnumerable<object[]> TestCases()
    {
        yield return new object[]
        {
            new int[] { -4,-2,1,4,8 },
            1  
        };

        yield return new object[]
        {
            new int[] {2,-1,1}, 
            1
        };
        
        yield return new object[]
        {
            new int[] {-100000,-100000}, 
            -100000
        };
        
        
    }
}