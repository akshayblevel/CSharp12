namespace CSharp12
{
    public class RefReadOnlyParams
    {
        public RefReadOnlyParams()
        {
            object name = "Akki";
            DisplayObject(ref name);  
        }

        public void DisplayObject(ref readonly object obj) 
        {
            // Throws an exception "Cannot assign to variable or use it as the right hand side of a ref assignment
            // because it is a readonly variable"
            obj = obj + "Patel"; 
            Console.WriteLine(obj);
        }
    }
}
