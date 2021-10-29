namespace Navistar.Common.Paginated
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class BaseTest
    {
        /// <summary>
        /// List of Catalogoss.
        /// </summary>
        /// <returns>IEnumerable Catalogoss.</returns>
        public IEnumerable<dynamic> GetData()
        {
            return new List<dynamic>()
            {
                new { Id = 1, FirstName = "FirstName1", LastName = "LastName1" },
                new { Id = 2, FirstName = "FirstName2", LastName = "LastName2" },
                new { Id = 3, FirstName = "FirstName3", LastName = "LastName3" },
                new { Id = 4, FirstName = "FirstName4", LastName = "LastName4" },
                new { Id = 5, FirstName = "FirstName5", LastName = "LastName5" },
                new { Id = 6, FirstName = "FirstName6", LastName = "LastName6" },
                new { Id = 7, FirstName = "FirstName7", LastName = "LastName7" },
                new { Id = 8, FirstName = "FirstName8", LastName = "LastName8" },
                new { Id = 9, FirstName = "FirstName9", LastName = "LastName9" },
                new { Id = 10, FirstName = "FirstName10", LastName = "LastName10" },
                new { Id = 11, FirstName = "FirstName11", LastName = "LastName11" },
                new { Id = 12, FirstName = "FirstName12", LastName = "LastName12" },
                new { Id = 13, FirstName = "FirstName13", LastName = "LastName13" },
                new { Id = 14, FirstName = "FirstName14", LastName = "LastName14" },
                new { Id = 15, FirstName = "FirstName15", LastName = "LastName15" },
                new { Id = 16, FirstName = "FirstName16", LastName = "LastName16" },
                new { Id = 17, FirstName = "FirstName17", LastName = "LastName17" },
                new { Id = 18, FirstName = "FirstName18", LastName = "LastName18" },
                new { Id = 19, FirstName = "FirstName19", LastName = "LastName19" },
                new { Id = 20, FirstName = "FirstName20", LastName = "LastName20" },
                new { Id = 21, FirstName = "FirstName21", LastName = "LastName21" },
            };
        }

        /// <summary>
        /// List of Catalogoss.
        /// </summary>
        /// <returns>IEnumerable Catalogoss.</returns>
        public IEnumerable<dynamic> GetDataFiltered(int page, int size)
        {
            return GetData().Skip(page * size).Take(size);
        }
    }
}
