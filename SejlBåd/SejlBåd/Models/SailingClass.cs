
namespace SejlBåd.Models
{
    public class SailingClass
    {
        public List<User> participants;
        public string ClassName { get; set; }
        public string ClassDate { get; set; }
        public int ClassSize { get; set; }
        public string ClassDetails { get; set; }
       

        public SailingClass(string className, string classDate, string classDetails)
        {
            ClassName = className;
            ClassDate = classDate;
            ClassDetails = classDetails;
            
        }

        public SailingClass()
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(ClassName)}={ClassName}, {nameof(ClassDate)}={ClassDate.ToString()}, {nameof(ClassSize)}={ClassSize.ToString()}, {nameof(ClassDetails)}={ClassDetails}}}";
        }
    }
}
