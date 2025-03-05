
using Api.Entities;

namespace Api.Repositories
{
    public interface ITaskEmployeeRepository
    {
        public Tasks GetTaskById(int id);
        public Employee GetEmployeeById(int id);
        public void Associate(TaskEmployee taskEmployee);

    }
}