namespace CSharp12
{
    public class OptionalParamInLambda
    {
        
        public OptionalParamInLambda() { 
        }

        public void addition()
        {
            // Default values for parameters in lambda expression. 
            // This mirros the syntax and rule for adding default values in methods, making lambda expression more flexible.

            var myFunc = (int x, int y = 5) => x + y;

            Console.WriteLine(myFunc(6)); // outputs 11
        }
    }
}
