namespace SejlBåd.Test
{
    public class NannasTest
    {
        public int MyProperty { get; set; }

        public NannasTest()
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(MyProperty)}={MyProperty.ToString()}}}";
        }
    }
}
