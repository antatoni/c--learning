public class LINQ
{
    static public void Test1()
    {
        List<int> scores = [97,92,80,81,55,33,45,100];//remains the same !

        // IEnumerable<int> scoreQuery = 
        // from score in scores
        // where score >= 80
        // orderby score descending
        // select score;

        var scoreQuery = scores
        .Where(s => s >=80)
        .OrderByDescending(s => s);
        
        List<int> passedScores = [.. scoreQuery];
        foreach(var score in passedScores)
        {
            Console.Write(score + " ");
        }
    }
    static public void Test2()
    {
        
    }
}