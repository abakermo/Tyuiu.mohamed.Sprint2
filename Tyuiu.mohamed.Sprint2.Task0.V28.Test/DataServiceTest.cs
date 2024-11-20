namespace Tyuiu.mohamed.Sprint2.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private DataService _dataService;

        [TestInitialize]
        public void Setup()
        {
            _dataService = new DataService();
        }

        [TestMethod]
        public void GetCompareOperations_WhenXEqualsY_ReturnsExpectedResults()
        {
            // Arrange
            int x = 111;
            int y = 111;

            // Act
            bool[] results = _dataService.GetCompareOperations(x, y);

            // Assert
            Assert.AreEqual(true, results[0]); // x == y
            Assert.AreEqual(false, results[1]); // x != y
            Assert.AreEqual(false, results[2]); // x < y
            Assert.AreEqual(false, results[3]); // x > y
            Assert.AreEqual(true, results[4]); // x <= y
            Assert.AreEqual(true, results[5]); // x >= y
        }

        [TestMethod]
        public void GetCompareOperations_WhenXLessThanY_ReturnsExpectedResults()
        {
            // Arrange
            int x = 111;
            int y = 735;

            // Act
            bool[] results = _dataService.GetCompareOperations(x, y);

            // Assert
            Assert.AreEqual(false, results[0]); // x == y
            Assert.AreEqual(true, results[1]); // x != y
            Assert.AreEqual(true, results[2]); // x < y
            Assert.AreEqual(false, results[3]); // x > y
            Assert.AreEqual(true, results[4]); // x <= y
            Assert.AreEqual(false, results[5]); // x >= y
        }

        [TestMethod]
        public void GetCompareOperations_WhenXGreaterThanY_ReturnsExpectedResults()
        {
            // Arrange
            int x = 735;
            int y = 111;

            // Act
            bool[] results = _dataService.GetCompareOperations(x, y);

            // Assert
            Assert.AreEqual(false, results[0]); // x == y
            Assert.AreEqual(true, results[1]); // x != y
            Assert.AreEqual(false, results[2]); // x < y
            Assert.AreEqual(true, results[3]); // x > y
            Assert.AreEqual(false, results[4]); // x <= y
            Assert.AreEqual(true, results[5]); // x >= y
        }
    }
}