using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
{
    var priorityQueue = new PriorityQueue();
    priorityQueue.Enqueue("Item1", 1);
    string result = priorityQueue.Dequeue();
    Assert.AreEqual("Item1", result);
}

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
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