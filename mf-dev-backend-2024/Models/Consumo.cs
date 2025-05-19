using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o descrição!")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Data!")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Valor!")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quilometragem!")]
        public int Km { get; set; }

        [Display(Name = "Tipo de Combustivel")]
        public TipoCombustivel Tipo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Veiculo!")]
        [Display(Name = "Veiculo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }
}
