public interface ITaskService
{
  public IEnumerable<Task> GetTasks();  
  public Task CreateTask(Task task);
  public Task UpdateTask(Task task);
  public bool DeleteTask(int id);
}