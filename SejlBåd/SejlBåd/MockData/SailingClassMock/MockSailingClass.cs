using SejlBåd.Models;

namespace SejlBåd.MockData.SailingClassMock
{
    public class MockSailingClass
    {
        private static List<SailingClass> sailingClasses = new List<SailingClass>()
        {
            new SailingClass("Junior Sejlads", "Torsdag kl 17:00", "Der sejles i optimistjoller, " +
                "Feva, Laserjoller under kyndigledelse" +
                "af kompetente instruktører. Har du lyst til " +
                "at lære at sejle, så mød op i klubben torsdag kl 17:00"),
            new SailingClass("Senior Sejlads", "Torsdag kl 17:00", "Der sejles i klubbens tre Lynæs-14 " +
                "kølbåde, i klubbens Wayfarer og i klubbes fem LaserJoller." +
                "Desuden er der private joller med i sejladserne")
        };


        public static List<SailingClass> GetMockClasses()
        {
            return sailingClasses;
        }
    }
}
