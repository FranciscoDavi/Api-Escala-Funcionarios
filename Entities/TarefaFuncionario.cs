namespace Api.Entities
{
    public class TarefaFuncionario
    {
        public int Id { get; set; }
        public int TarefaID { get; set; }
        public Tarefa Tarefa{ get; set; }
        public int FuncionarioID { get; set; }
        public Funcionario Funcionario{ get; set; }
     
    }
}