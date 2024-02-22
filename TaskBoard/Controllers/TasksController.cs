using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/tasks")]
public class TasksController:ControllerBase
{
     private readonly ITaskService _taskService;
     
     public TasksController(ITaskService taskService){
        _taskService = taskService;
     }

     [HttpPost]
     public IActionResult CreateTask([FromBody] Task task)
     {
        try{
        _taskService.CreateTask(task);
        return Ok(task);
        }
        catch(Exception ex){
            return BadRequest("Please check if the Task has data. Error:"+ ex);
        }
     }
     [HttpPut]
     public IActionResult UpdateTask([FromBody] Task task)
     {
        try{
        _taskService.UpdateTask(task);
        return Ok(task);
        }
        catch(Exception ex){
            return BadRequest("Please check if the Task data is correct. Error: "+ ex);
        }
     }
}