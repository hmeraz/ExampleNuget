namespace Navistar.Common.Paginated
{
    using Navistar.Common.Dtos;
    using NUnit.Framework;

    [TestFixture]
    public class Tests : BaseTest
    {
        private PaginatedDto<dynamic> paginatedDto;
        [OneTimeSetUp]
        public void Setup()
        {
            
        }

        [TestCase(3, 1, 10, 21)]
        [TestCase(3, 2, 10, 21)]
        [TestCase(3, 3, 10, 21)]
        [TestCase(2, 1, 10, 21)]
        public void PaginatedWithDataFiltered(int pages, int page, int size, int registries)
        {
            paginatedDto = new PaginatedDto<dynamic>(page, size, registries, base.GetDataFiltered(page, size));

            Assert.AreEqual(pages, paginatedDto.Pages);
        }
    }
}