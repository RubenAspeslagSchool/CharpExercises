namespace AdvancedTopics.Exercise8
{
    public class Desktop : Computer
    {
        public Desktop(/*string brand, Color color*/)/*: base(brand, color)*/
        {

        }

        public override string ToString() => $"{base.ToString()}and is a {nameof(Desktop)}";
    }
}
