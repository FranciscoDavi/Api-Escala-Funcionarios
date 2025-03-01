namespace Api.DTOS
{
    public class TarefaDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descricao { get; set; }

        public List<string> Funcionarios {get; set; } = new ();
        public List<string> Turnos {get; set; } = new ();
    }
}