using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AcrServices.Models
{
    public class Contact
    {
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("Telefone Para Contato")]
        public string Telefone { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Assunto")]
        public string Assunto { get; set; }

        [DisplayName("Corpo Email")]
        public string CorpoEmail { get; set; }
    }

}