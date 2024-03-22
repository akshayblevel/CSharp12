namespace CSharp12
{
    /*
        Using alias directive to include any type, not just named types
        Creation of semantic aliases for complex types like tuples, arrays and pointer types
    */

    using Coordinate = System.ValueTuple<int, int>;

    public class AliasAnyType
    {
        public AliasAnyType()
        {
        }

        public void SetType() 
        {
            Coordinate location = (10, 20);
            Console.WriteLine(location.ToString());
        }
    }
}
