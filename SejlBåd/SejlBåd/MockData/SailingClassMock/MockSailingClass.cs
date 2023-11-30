using SejlBåd.Models;

namespace SejlBåd.MockData.SailingClassMock
{
    public class MockSailingClass
    {
        private static List<Models.SailingClass> sailingClasses = new List<Models.SailingClass>()
        {
            new Models.SailingClass("Junior Sejlads", "Torsdag kl 17:00", "Der sejles i optimistjoller, " +
                "Feva, Laserjoller under kyndigledelse" +
                "af kompetente instruktører. Har du lyst til " +
                "at lære at sejle, så mød op i klubben torsdag kl 17:00")
        };

        public static List<Models.SailingClass> GetMockClasses()
        {
            return sailingClasses;
        }
    }
}
