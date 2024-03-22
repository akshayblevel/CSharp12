namespace CSharp12
{
    /*
        Enhance performance by enabling developers to create fixed-size arrays in struct types.
        Useful for optimizing memory layout and improving runtime performance.
    */
    [System.Runtime.CompilerServices.InlineArray(10)]
    public struct InlineArray
    {
        public string name;
    }

    public class DemoInlineArray
    {
        public DemoInlineArray()
        {
            var inlineArray = new InlineArray();

            for (int i = 0; i < 10; i++)
            {
                inlineArray[i] = "Akki" + i;
            }

            foreach (var item in inlineArray)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
