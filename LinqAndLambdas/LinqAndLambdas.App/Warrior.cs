namespace LinqAndLambdas
{
    public class Warrior
    {
        string _name;
        int _height;
        int _weight;

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }


    }
}