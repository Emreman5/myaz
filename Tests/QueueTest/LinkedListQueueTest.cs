using Queue;

namespace QueueTest
{
    public class LinkedListQueueTest
    {
        [Fact]
        public void QueueEnqueueTest()
        {
            // Arrange
            var queue = new LinkedListQueue<int>();

            // Act
            queue.EnQueue(1);
            queue.EnQueue(2);
            queue.EnQueue(3);
            queue.EnQueue(4);
            queue.EnQueue(5);

            // Assert
            Assert.Equal(5, queue.Count);
            Assert.Equal(1, queue.Peek());
        }

        [Fact]
        public void QueueDequeueTest()
        {
            // Arrange
            var queue = new LinkedListQueue<int>();

            // Act
            queue.EnQueue(1);
            queue.EnQueue(2);
            queue.EnQueue(3);
            queue.EnQueue(4);
            queue.EnQueue(5);

            // Assert
            Assert.Equal(5, queue.Count);
            Assert.Equal(1, queue.DeQueue());
            Assert.Equal(2, queue.DeQueue());
            Assert.Equal(3, queue.DeQueue());
            Assert.Equal(4, queue.DeQueue());
            Assert.Equal(5, queue.DeQueue());
        }

        [Fact]
        public void QueueDequeueExceptionTest()
        {
            // Arrange
            var queue = new LinkedListQueue<int>();

            // Act


            // Assert
            Assert.Throws<Exception>(() => queue.DeQueue());
        }
    }
}