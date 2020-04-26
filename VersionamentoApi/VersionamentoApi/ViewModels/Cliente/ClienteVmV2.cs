using System.ComponentModel.DataAnnotations;

namespace VersionamentoApi.ViewModels.Cliente
{
    public class ClienteVmV2
    {
        [Required]
        public string Rg { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string NomeMae { get; set; }
    }
}
