using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class StaffScheduleDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<ShiftEmployee> ShiftEmployees { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<TaskEmployee> TaskEmployees { get; set; }
        public DbSet<ShiftTask> ShiftTasks { get; set; }

        public StaffScheduleDBContext(DbContextOptions<StaffScheduleDBContext> options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relacionamento entre Turnos e Funcionarios
           
            modelBuilder.Entity<ShiftEmployee>()
                .HasKey(ft => ft.Id); //Define id como chave primaria

            modelBuilder.Entity<ShiftEmployee>()
                .HasOne(ft => ft.Employee)
                .WithMany(ft => ft.ShiftEmployees)
                .HasForeignKey(ft => ft.EmployeeId);
            
            modelBuilder.Entity<ShiftEmployee>()
                .HasOne(ft => ft.Shift)
                .WithMany(ft => ft.ShiftEmployees)
                .HasForeignKey(ft => ft.ShiftId);

            // Relacionamento entre Tarefas e funcionarios
            modelBuilder.Entity<TaskEmployee>()
                .HasKey(tf => tf.Id);

             modelBuilder.Entity<TaskEmployee>()
                .HasOne(tf => tf.Employee)
                .WithMany(tf => tf.TaskEmployees)
                .HasForeignKey(tf => tf.EmployeeId);

            modelBuilder.Entity<TaskEmployee>()
                .HasOne(tf => tf.Task)
                .WithMany(tf => tf.TaskEmployees)
                .HasForeignKey(tf => tf.TaskId);
            
            /*Relacionamento entre Turnos e Tarefas*/
            modelBuilder.Entity<ShiftTask>()
                .HasKey(tt => tt.Id);
        
            modelBuilder.Entity<ShiftTask>()
                .HasOne(tt => tt.Task)
                .WithMany(tt => tt.ShiftTasks)
                .HasForeignKey(tt => tt.TaskId);
            
            modelBuilder.Entity<ShiftTask>()
                .HasOne(tt => tt.Shift)
                .WithMany(tt => tt.ShiftTasks)
                .HasForeignKey(tt => tt.ShiftId);         

            base.OnModelCreating(modelBuilder);
        }




    }
}