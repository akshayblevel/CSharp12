namespace CSharp12
{
    public class PrimaryConstructor(string fname, string lname)
    {
        //FName & LName are in scope for the entire class body
        public string FName => fname;
        public string LName => lname;
    }

}
