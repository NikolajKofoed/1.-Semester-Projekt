namespace SejlBåd.MockData.EventMock
{
    public class EventMockData
    {
        private static List<Models.Event> _events = new List<Models.Event>()
        {
            new Models.Event(3, "En tur i søen", "Det er en tur i søen", "28/12-2023"),
            new Models.Event(3, "En tur i søen 2", "Det er en tur i søen", "29/12-2023"),
            new Models.Event(3, "En tur i søen 3", "Det er en tur i søen", "30/12-2023")
        };

        public static List<Models.Event> GetEvents()
        {
            return _events;
        }
    }
}
