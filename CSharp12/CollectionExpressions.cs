namespace CSharp12
{
    public class CollectionExpressions
    {
        public void DoSomething()
        {
            // Before C# 12
            List<int> numbers = new List<int> { 1, 2, 3};

            // C# 12
            List<int> nums = [1, 2, 3];
        }
    }
}
