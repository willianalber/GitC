using RevisaoWebApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RevisaoWebApi.Models
{
    public class CustomValidFilds : ValidationAttribute
    {
        ContextDB db = new ContextDB();

        private ValidFields TypeFild;

        public CustomValidFilds(ValidFields type)
        {
            TypeFild = type;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                switch (TypeFild)
                {
                    case ValidFields.ValidaLogin:
                        {
                            Usuario user = db.usuarios.FirstOrDefault(x => x.login == value.ToString());

                            if (user == null)
                            {
                                return ValidationResult.Success;
                            }
                            else
                            {
                                return new ValidationResult("Login já cadastrado em nossa base de dados.");
                            }
                        }break;
                    case ValidFields.ValidaEmail:
                        break;
                    case ValidFields.ValidaSenha:
                        break;
                    case ValidFields.ValidaNome:
                        {                           
                                if (value.ToString().Contains("GIOMAR"))
                                {
                                    return ValidationResult.Success;
                                }
                                else
                                {
                                    return new ValidationResult("Muito triste com você.");
                                }
                        }break;
                    default:
                        break;
                }
            }
            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório.");
        }
    }
}