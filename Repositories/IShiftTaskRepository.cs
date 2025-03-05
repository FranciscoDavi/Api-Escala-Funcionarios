using Api.Entities;

namespace Api.Repositories
{
    public interface IShiftTaskRepository
    {
        public Tasks GetTaskById(int id);
        public Shift GetShiftById(int id);
        public void Associate(ShiftTask taskShift);

    }
}