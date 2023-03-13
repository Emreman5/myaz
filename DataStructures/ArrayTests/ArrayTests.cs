namespace ArrayTests
{
    // Unit Test
    public class ArrayTests
    {
        [Fact]
        public void Array_Count_Test()
        {
            // Arrange
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");
            array.Add("Can");

            // Act
            int count = array.Count;

            // Assertion
            Assert.Equal(3, count);
            Assert.Equal(4, array.Capacity);
        }

        [Fact]
        public void Array_Add_Test()
        {
            // Arrange
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");
            array.Add("Can");
            array.Add("Canan");
            array.Add("Filiz");

            // Act
            int count = array.Count;

            // Assertion
            Assert.Equal(5, count);
            Assert.Equal(8, array.Capacity);
        }

        [Fact]
        public void Array_GetItem_Test()
        {
            // Arrange
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");

            // Act
            var item = array.GetItem(1);

            // Assert
            Assert.Equal(item, "Mehmet");
        }

        [Fact]
        public void Arrry_Find_Test()
        {
            // Arrange
            var array = new Array.Array();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);

            // Act
            int result = array.Find(2);
            
            // Assert
            Assert.Equal(result, 1);
        }

        [Fact]
        public void Array_GetEnumerator()
        {
            // Arrange
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");
            array.Add("Can");

            string result = "";
            foreach (var item in array)
            {
                result = string.Concat(result, item);
            }

            Assert.Equal(result, "AhmetMehmetCan");

        }
    }
}