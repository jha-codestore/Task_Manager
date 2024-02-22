using NUnit.Framework;
using Moq;

[TestFixture]
public class TasksControllerTests
{
    public Task task { get; set; }
    public Mock<ITaskService> taskServiceMock{get;set;} 
    [OneTimeSetUp]
    public void Setup()
    {
        taskServiceMock= new Mock<ITaskService>();
        task = new Task(){
            Id=1,
            Name= "Login Page Creation",
            Description = "Create a login page where user can enter credentials and should be able to login if valid"
        };
    }
    [Test]
    public void CreateTask_ReturnsOk()
    {
        //Arrange
        var taskServiceMock = new Mock<ITaskService>();
        var tasksController = new TasksController(taskServiceMock.Object);
        
        //Act
        var result = tasksController.CreateTask(task);

        //Assert
        Assert.AreEqual(task, okResult.Value);
        
    }
    [Test]
    public void UpdateTask_ReturnsOk()
    {
        //Arrange
        var taskServiceMock = new Mock<ITaskService>();
        var tasksController = new TasksController(taskServiceMock.Object);
        var task = new Task(){
            Id=1,
            Name= "Login Page Creation",
            Description = "Create a login page where user can enter credentials and should be able to login if valid"
        };
        
        //Act
        var result = tasksController.UpdateTask(task);

        //Assert
        Assert.AreEqual(task, okResult.Value);
        
    }
    [Test]
    public void CreateTask_Failure()
    {
        //Arrange
        var tasksController = new TasksController(taskServiceMock.Object);
        //Act
        TestDelegate testDelegate = () =>tasksController.CreateTask(new Task());
        //Assert
        Assert.Throws<InvalidDataException>(testDelegate);

    }
}