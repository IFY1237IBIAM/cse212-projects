using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue a single item with priority 1 and dequeue it.
    // Expected Result: The item should be dequeued correctly.
    // Defect(s) Found: None, test passed as expected.
    public void TestPriorityQueue_1()
{
    var priorityQueue = new PriorityQueue();
    priorityQueue.Enqueue("Item1", 1);
    string result = priorityQueue.Dequeue();
    Assert.AreEqual("Item1", result);
}

    [TestMethod]
    // Scenario: Enqueue items with different priorities and dequeue the highest priority item.
    // Expected Result: The highest priority item should be dequeued first.
    // Defect(s) Found:The priority queue was not correctly ordering items based on priority. 
    public void TestPriorityQueue_SingleHighPriorityDequeue()
    {
       var pq = new PriorityQueue();
       pq.Enqueue("Low", 1);
       pq.Enqueue("High", 5);
       pq.Enqueue("Medium", 3);

       string result = pq.Dequeue();
       Assert.AreEqual("High", result);
    }


    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Enqueue items with the same priority and dequeue them.
    // Expected Result: Items with the same priority should be dequeued in the order they were last inserted.
    // Defect(s) Found: The priority queue was not correctly handling items with the same priority, dequeuing them in the wrong order.
    public void TestPriorityQueue_DequeueOrderOnSamePriority()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 3);
        pq.Enqueue("B", 3);
        pq.Enqueue("C", 2);

        // Should return B since it's the last inserted with highest priority (equal to A)
        Assert.AreEqual("B", pq.Dequeue());
    }
}