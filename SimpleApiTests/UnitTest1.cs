namespace SimpleApiTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Addition()
        {
            var service = new SimpleApi.Service.CalcService();
            Assert.Equal(42, service.Addition(20, 22));
        }
    }
}
