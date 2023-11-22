using System;
namespace Task1.Models.Interfaces
{
	public interface ITaskService
	{
        Task<IEnumerable<MyTask>> GetAllTasks();
        Task<MyTask> GetTaskById(int taskId);
        Task<MyTask> CreateTask(MyTask task);
        Task<MyTask> UpdateTask(int taskId, MyTask updatedTask);
        Task DeleteTask(int taskId);

    }
}

