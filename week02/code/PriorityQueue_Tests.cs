using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Adding people and taking them out of queue based on value priority
    // Expected Result: 
    // Defect(s) Found: not comparing to dequeue first value of same priority out first
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("bob", 5);
        priorityQueue.Enqueue("kevin", 2);

        var firstDequeue = priorityQueue.Dequeue();
        Assert.AreEqual("bob", firstDequeue, "Dequeue returns highest priority item.");

        priorityQueue.Enqueue("alice", 2);

        var secondDequeue = priorityQueue.Dequeue();
        Assert.AreEqual("kevin", secondDequeue, "if priority value is same, front item first");

        var thirdDequeue = priorityQueue.Dequeue();
        Assert.AreEqual("alice", thirdDequeue);

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), "The queue is empty");
    }

    [TestMethod]
    // Scenario: Adding people and taking them out of queue based on value priority
    // Expected Result: 
    // Defect(s) Found: skipping last number in queue
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("blue", 1);
        priorityQueue.Enqueue("green", 1);

        var firstDequeue = priorityQueue.Dequeue();
        Assert.AreEqual("blue", firstDequeue, "Dequeue returns highest or first priority item.");

        priorityQueue.Enqueue("red", 5);

        var secondDequeue = priorityQueue.Dequeue();
        Assert.AreEqual("red", secondDequeue, "highest item should be first");

        var thirdDequeue = priorityQueue.Dequeue();
        Assert.AreEqual("green", thirdDequeue);

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), "The queue is empty");


    }

    // Add more test cases as needed below.
}