using RevisaoWebApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
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
                    case ValidFields.ValidaLogin: {return ValidarLogin(value);}
                    case ValidFields.ValidaEmail: {return ValidarEmail(value, validationContext.DisplayName);}                        
                    case ValidFields.ValidaSenha: {return ValidarSenha(value); }
                    case ValidFields.ValidaNome:  {return ValidarNome(value); }                    
                }                
            }
            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório.");
        }

        private ValidationResult ValidarEmail(object value, string displayField)
        {
            var result = Regex.IsMatch(value.ToString(), 
                @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (result)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult($"O campo {displayField} é invalido.");
        }

        private ValidationResult ValidarLogin(object value)
        {
            Usuario user = db.usuarios.FirstOrDefault(x => x.login == value.ToString());

            if (user == null)
            {
                return ValidationResult.Success;
            }           
            return new ValidationResult("Login já cadastrado em nossa base de dados.");           
        }

        private ValidationResult ValidarNome(object value)
        {
            if (value.ToString().Contains("GIOMAR"))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Muito triste com você. Precisas adicionar o GIOMAR no nome");           
        }

        private ValidationResult ValidarSenha(object value)
        {
            if (value.ToString().Length >= 8  && value.ToString().Length <= 16)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("O campo senha precisa conter de 8 a 16 caracteres! Verifique.");
        }

        private bool VerificaNumero(string senha)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (senha.Contains(i.ToString()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}