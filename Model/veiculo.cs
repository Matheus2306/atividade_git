namespace atividade_git.Model
{
    public class veiculo
    {
        public Guid VeiculoId { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public int ano { get; set; }

        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
    }
}
