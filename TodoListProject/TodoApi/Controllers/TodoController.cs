using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodolistModelsClassLibrary.Models;
using TodoApi;

[Route("api/[controller]/[action]")]
[ApiController]
public class TodoController : ControllerBase
{
    private readonly TodoContext _dbContext;

    public TodoController(TodoContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var todoItems = _dbContext.TodoItems.Where(item => item.CompletedDate == null).ToList();
        return Ok(todoItems);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var todoItem = _dbContext.TodoItems.FirstOrDefault(item => item.Id == id);
        if (todoItem == null)
        {
            return NotFound();
        }
        return Ok(todoItem);
    }

    [HttpPost]
    public IActionResult Create([FromBody] TodoItem todoItem)
    {
        _dbContext.TodoItems.Add(todoItem);
        _dbContext.SaveChanges();
        return CreatedAtAction(nameof(GetById), new { id = todoItem.Id }, todoItem);
    }

    [HttpPost("{id}")]
    public IActionResult Complete(int id)
    {
        var todoItem = _dbContext.TodoItems.FirstOrDefault(item => item.Id == id);
        if (todoItem == null)
        {
            return NotFound();
        }
        todoItem.CompletedDate = DateTime.Now;
        _dbContext.SaveChanges();
        return Ok(todoItem);
    }
}
