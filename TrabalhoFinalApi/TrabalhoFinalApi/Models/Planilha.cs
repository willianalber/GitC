using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace TrabalhoFinalApi.Models
{
    public class Planilha
    {
        public static List<Marca> RetornaListaMarcasPlanilha(string diretorio, int IdTipoVeiculo)
        {
            var reader = new StreamReader(File.OpenRead(diretorio));
            
            List<Marca> listaMarca = new List<Marca>();
            
            
            while (!reader.EndOfStream)
            {
                string linha = reader.ReadLine();
                if (!String.IsNullOrWhiteSpace(linha))
                {
                    string[] valor = linha.Split(';');


                    if (valor.Length > 1)
                    {
                        listaMarca.Add(new Marca() { Codigo = int.Parse(valor[0]), Descricao = valor[1], IDTipoVeiculo = IdTipoVeiculo });
                                        
                    }                    
                }
            }
            return listaMarca;
        }

        public static List<Modelo> RetornaListaModeloPlanilha(string diretorio, int IdTipoVeiculo)
        {
            var reader = new StreamReader(File.OpenRead(diretorio));

            List<Modelo> listaModelo = new List<Modelo>();


            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (!String.IsNullOrWhiteSpace(line))
                {
                    string[] values = line.Split(';');


                    if (values.Length > 1)
                    {
                        listaModelo.Add(new Modelo() { IDMarca = int.Parse(values[0]), Descricao = values[1], IDTipoVeiculo = IdTipoVeiculo});
                    }
                }
            }
            return listaModelo;
        }

    }
}