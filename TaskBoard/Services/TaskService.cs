
public class TaskService : ITaskService
{
    
    private readonly List<Task> _tasks = new List<Task>();

    public IEnumerable<Task> GetTasks()
    {
        return _tasks;
    }
    public Task CreateTask(Task task)
    {
        if(task!= null)
        {
            _tasks.Add(task);
            return task;
        } 
        else 
            throw new InvalidDataException();   
    }
    public Task UpdateTask(Task task)
    {
        var existingTask = _tasks.FirstOrDefault(t=>t.Id==task.Id);
        if(existingTask==null)
            throw new InvalidDataException();
        else
        {
            existingTask.Name = task.Name;
            existingTask.Description = task.Description;
            existingTask.DeadLine = task.DeadLine;
            return existingTask;
        }
    }
    public bool DeleteTask(int id)
    {
        throw new NotImplementedException();
    }
}