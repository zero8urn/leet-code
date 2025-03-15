using DSA.Problems.Arrays;

namespace DSA.UnitTests.Arrays;

public class MergeAlternatelyTests
{
    private readonly MergeAlternately.Solution _solution = new();

    [Theory]
    [MemberData(nameof(TestCases))]
    public void MainSolution_ShouldReturnExpectedResult(string word1, string word2, string expected)
    {
        // act
        var actual = _solution.MergeAlternatelyV2(word1, word2);

        // assert
        Assert.Equal(expected, actual);
    }

    public static IEnumerable<object[]> TestCases()
    {
        yield return new object[] { "abc", "def", "adbecf" };

        yield return new object[] { "abc", "defgh", "adbecfgh" };

        yield return new object[] { "abcxy", "def", "adbecfxy" };
    }
}
