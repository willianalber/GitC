using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Linq;
using System.Web;
using TrabalhoFinalApi.Models;
using TrabalhoFinalApi.Enuns;

namespace TrabalhoFinalApi.Models
{
    public class CustomValidFilds : ValidationAttribute
    {
        ContextDb db = new ContextDb();

        private EnumValida TypeFild;

        public CustomValidFilds(EnumValida type)
        {
            TypeFild = type;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                switch (TypeFild)
                {
                    case EnumValida.validaPlaca: { return validarPlaca(value); }
                    
                }
            }

            return base.IsValid(value, validationContext);
        }

        

        private ValidationResult validarPlaca(object value)
        {
            bool placaCarroBrasil = Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[-][0-9]{4}$");

            bool placaCarroMercoSul = Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}$");

            bool placaMotoMercoSul = Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[0-9]{2}[a-zA-Z]{1}[0-9]{1}$");

            if(placaCarroBrasil|| placaCarroMercoSul|| placaMotoMercoSul)
            {
                if (verificaSeExisteVeiculo(value.ToString()))
                {
                    return new ValidationResult("A placa informada já está cadastrada!");
                }

                return ValidationResult.Success;
            } 
            return new ValidationResult("O campo Placa é invalido!");
        }

        private bool verificaSeExisteVeiculo(string prPlaca)
        {
            foreach (var item in db.veiculos)
            {
                if (item.Placa == prPlaca)
                {
                    return true;
                }                
            }
            return false;
        }

    }
}