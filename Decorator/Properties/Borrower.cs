namespace Decorator.Properties
{
    public class Borrower
    {
        private string name;

        public Borrower(string _name)
        {
            this.name = _name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}