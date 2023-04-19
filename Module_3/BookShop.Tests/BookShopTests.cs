namespace BookShop.Tests
{
    public class Tests
    {
        private Order order { get; set; } =null!;

        [SetUp]
        public void Setup()
        {
            order = new Order();
        }

        [Test]
        public void calculatePrice_Test ()
        {
            var books = new[] { 1, 1, 2, 2, 3, 3, 4, 5 };
            var price = order.calculatePrice(books);
            Assert.That(price, Is.EqualTo(51.6));
        }
    }
}