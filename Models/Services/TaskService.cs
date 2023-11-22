using System;
using Microsoft.EntityFrameworkCore;
using Task1.Data;
using Task1.Models.Interfaces;

namespace Task1.Models.Services
{
	public class TaskService : ITaskService
	{
        private readonly TaskDbContext _context;

        public TaskService(TaskDbContext context)
        {
            _context = context;
        }



        public async Task<IEnumerable<MyTask>> GetAllTasks()
        {
            return await _context.Tasks.ToListAsync();
        }


        public async Task<MyTask> GetTaskById(int taskId)
        {
            return await _context.Tasks.FindAsync(taskId);
        }


        public async Task<MyTask> CreateTask(MyTask task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return task;
        }



        public async Task<MyTask> UpdateTask(int taskId, MyTask updatedTask)
        {
            var existingTask = await _context.Tasks.FindAsync(taskId);
            if (existingTask == null)
            {
                throw new InvalidOperationException("Task not found");
            }

            existingTask.Name = updatedTask.Name;
            existingTask.Description = updatedTask.Description;
            existingTask.Deadline = updatedTask.Deadline;

            await _context.SaveChangesAsync();
            return existingTask;
        }



        public async Task DeleteTask(int taskId)
        {
            var taskToDelete = await _context.Tasks.FindAsync(taskId);
            if (taskToDelete != null)
            {
                _context.Tasks.Remove(taskToDelete);
                await _context.SaveChangesAsync();
            }
        }




    }
}

