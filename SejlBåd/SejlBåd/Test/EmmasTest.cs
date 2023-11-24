namespace SejlBåd.Test
{
    public class EmmasTest
    {
        public int MyProperty { get; set; }

        public EmmasTest()
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(MyProperty)}={MyProperty.ToString()}}}";
        }
    }
}
