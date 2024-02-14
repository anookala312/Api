using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodolistModelsClassLibrary.Models;

namespace UnitTest;


[TestClass]
public class ToDoItemTests
{
    [TestMethod]
    public void ToDoItem_ShouldHaveDefaultValues()
    {
        // Arrange & Act
        var todoItem = new TodoItem();

        // Assert
        Assert.AreEqual(0, todoItem.Id);
        Assert.IsNull(todoItem.Description);
        Assert.AreEqual(default(DateTime), todoItem.CreatedDate);
        Assert.IsNull(todoItem.CompletedDate);
    }

    [TestMethod]
    public void ToDoItem_CanBeCreatedWithValues()
    {
        // Arrange
        var currentDate = DateTime.Now;

        // Act
        var todoItem = new TodoItem
        {
            Id = 1,
            Description = "Sample Todo",
            CreatedDate = currentDate,
            CompletedDate = currentDate.AddHours(1)
        };

        // Assert
        Assert.AreEqual(1, todoItem.Id);
        Assert.AreEqual("Sample Todo", todoItem.Description);
        Assert.AreEqual(currentDate, todoItem.CreatedDate);
        Assert.AreEqual(currentDate.AddHours(1), todoItem.CompletedDate);
    }

    [TestMethod]
    public void ToDoItem_CompletedDateIsNullInitially()
    {
        // Arrange & Act
        var todoItem = new TodoItem();

        // Assert
        Assert.IsNull(todoItem.CompletedDate);
    }

    [TestMethod]
    public void ToDoItem_CompleteSetsCompletedDate()
    {
        // Arrange
        var todoItem = new TodoItem();

        // Act
        todoItem.CompletedDate = DateTime.Now;

        // Assert
        Assert.IsNotNull(todoItem.CompletedDate);
        Assert.IsInstanceOfType(todoItem.CompletedDate, typeof(DateTime));
    }
}
