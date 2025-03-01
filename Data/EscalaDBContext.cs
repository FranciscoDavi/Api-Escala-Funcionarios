using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class EscalaDBContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<FuncionarioTurno> FuncionarioTurnos { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<TarefaFuncionario> TarefasFuncionarios { get; set; }
        public DbSet<TarefaTurno> TarefasTurnos { get; set; }

        public EscalaDBContext(DbContextOptions<EscalaDBContext> options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relacionamento entre Funcionarios e Turnos
           
            modelBuilder.Entity<FuncionarioTurno>()
                .HasKey(ft => ft.Id); //Define id como chave primaria

            modelBuilder.Entity<FuncionarioTurno>()
                .HasOne(ft => ft.Funcionario)
                .WithMany(ft => ft.FuncionariosTurnos)
                .HasForeignKey(ft => ft.FuncionarioID);
            
            modelBuilder.Entity<FuncionarioTurno>()
                .HasOne(ft => ft.Turno)
                .WithMany(ft => ft.FuncionariosTurnos)
                .HasForeignKey(ft => ft.TurnoID);

            // Relacionamento entre Tarefas e funcionarios
            modelBuilder.Entity<TarefaFuncionario>()
                .HasKey(tf => tf.Id);

             modelBuilder.Entity<TarefaFuncionario>()
                .HasOne(tf => tf.Funcionario)
                .WithMany(tf => tf.TarefasFuncionarios)
                .HasForeignKey(tf => tf.FuncionarioID);

            modelBuilder.Entity<TarefaFuncionario>()
                .HasOne(tf => tf.Tarefa)
                .WithMany(tf => tf.TarefasFuncionarios)
                .HasForeignKey(tf => tf.TarefaID);
            
            modelBuilder.Entity<TarefaTurno>()
                .HasKey(tt => tt.Id);
            /**/
            modelBuilder.Entity<TarefaTurno>()
                .HasOne(tt => tt.Tarefa)
                .WithMany(tt => tt.TarefasTurnos)
                .HasForeignKey(tt => tt.TarefaID);
            
            modelBuilder.Entity<TarefaTurno>()
                .HasOne(tt => tt.Turno)
                .WithMany(tt => tt.TarefasTurnos)
                .HasForeignKey(tt => tt.TurnoID);         

            base.OnModelCreating(modelBuilder);
        }




    }
}