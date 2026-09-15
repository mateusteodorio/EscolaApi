using System.Text.Json.Serialization;

namespace EscolaApi.Models
{

    public class Matricula
    {
        public int Id { get; set; }

        public string NomeAluno { get; set; }

        public string EmailAluno { get; set; }

        public DateTime DaraMatricula { get; set; }

        public int CursoID { get; set; }

        [JsonIgnore]

        public Curso? Curso { get; set; }
    }

}
