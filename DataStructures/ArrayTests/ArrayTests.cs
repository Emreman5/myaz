namespace ArrayTests
{
    public class ArrayTests
    {
        [Fact]
        public void Array_Count_Test()
        {
            // Arrange
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");

            // Act
            int count = array.Count;

            // Assertion
            Assert.Equal(2, count);
        }
    }
}