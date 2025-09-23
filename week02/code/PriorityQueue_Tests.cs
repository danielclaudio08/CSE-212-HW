using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
  [TestMethod]
  // Scenario: Create a priority queue, add several items with varying priorities, and dequeue all items.
  // Expected Result: Items should be dequeued in order of priority (highest first) → C, A, B.
  // Defect(s) Found: Dequeue did not actually remove the item from the queue — it only returned its value.
  public void TestPriorityQueue_1()
  {
    var priorityQueue = new PriorityQueue();
    priorityQueue.Enqueue("A", 2);
    priorityQueue.Enqueue("B", 1);
    priorityQueue.Enqueue("C", 3);

    Assert.AreEqual("C", priorityQueue.Dequeue());
    Assert.AreEqual("A", priorityQueue.Dequeue());
    Assert.AreEqual("B", priorityQueue.Dequeue());
  }

  [TestMethod]
  // Scenario: Add multiple items with the same priority → expect FIFO removal order.
  // Expected Result: A (Pri:5) then B (Pri:5) then C (Pri:5).
  // Defect(s) Found: Incorrect comparison logic (`>=`) caused the later items to overwrite earlier ones, breaking FIFO.
  public void TestPriorityQueue_2()
  {
    var priorityQueue = new PriorityQueue();
    priorityQueue.Enqueue("A", 5);
    priorityQueue.Enqueue("B", 5);
    priorityQueue.Enqueue("C", 5);

    Assert.AreEqual("A", priorityQueue.Dequeue());
    Assert.AreEqual("B", priorityQueue.Dequeue());
    Assert.AreEqual("C", priorityQueue.Dequeue());
  }

  // Add more test cases as needed below.
}