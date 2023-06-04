using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o usuário")]
        [DisplayName("Usuario:")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [DisplayName("Senha:")]
        public string Senha { get; set; }

        [DisplayName("Lembrar Me")]
        public bool LembrarMe { get; set; }

    }
}