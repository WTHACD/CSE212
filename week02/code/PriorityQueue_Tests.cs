using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities and dequeue them.
    // The highest priority item should be dequeued first.
    // Expected Result: Dequeue returns "High", then "Medium", then "Low".
    // Defect(s) Found: None. The code worked as expected.
    public void TestPriorityQueue_DequeueBasic()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Medium", 2);
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 3);

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same highest priority.
    // The item enqueued first should be dequeued first (FIFO).
    // Expected Result: Dequeue returns "First", then "Second".
    // Defect(s) Found: None. The implementation correctly handles FIFO for items with the same priority by using '>' instead of '>=' in the loop, which preserves the order of insertion.
    public void TestPriorityQueue_SamePriorityFIFO()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Second", 5);

        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Try to dequeue from an empty queue.
    // Expected Result: An InvalidOperationException should be thrown.
    // Defect(s) Found: None. The code correctly throws an exception when the queue is empty.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail($"Unexpected exception of type {e.GetType()} caught: {e.Message}");
        }
    }

    [TestMethod]
    // Scenario: A complex sequence of enqueue and dequeue operations to test the queue's integrity.
    // Expected Result: The sequence of dequeued items should be correct based on priority and FIFO.
    // Defect(s) Found: None. The code passed this complex scenario without issues.
    public void TestPriorityQueue_Complex()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);
        Assert.AreEqual("B", priorityQueue.Dequeue()); // Dequeue B (pri 5)

        priorityQueue.Enqueue("D", 5);
        priorityQueue.Enqueue("E", 4);

        Assert.AreEqual("D", priorityQueue.Dequeue()); // Dequeue D (pri 5)
        Assert.AreEqual("E", priorityQueue.Dequeue()); // Dequeue E (pri 4)
        Assert.AreEqual("C", priorityQueue.Dequeue()); // Dequeue C (pri 3)
        Assert.AreEqual("A", priorityQueue.Dequeue()); // Dequeue A (pri 2)
    }
}