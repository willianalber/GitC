namespace TrabalhoFinalApi.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TrabalhoFinalApi.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TrabalhoFinalApi.Models.ContextDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TrabalhoFinalApi.Models.ContextDb context)
        {
            // setup inicial de Tipo de veiculos
            var ListcaTipoVeiculo = new List<TipoVeiculo>();

            ListcaTipoVeiculo.Add(new TipoVeiculo() { Descricao = "Automóvel" });
            ListcaTipoVeiculo.Add(new TipoVeiculo() { Descricao = "Moto" });
            ListcaTipoVeiculo.Add(new TipoVeiculo() { Descricao = "Bicicleta" });
            ListcaTipoVeiculo.Add(new TipoVeiculo() { Descricao = "Patinete" });

            foreach (var item in ListcaTipoVeiculo)
            {
                context.tipoVeiculos.Add(item);

            }

            //context.SaveChanges();

            // Setup inicial de marcas
            List<Marca> listaMarca = new List<Marca>();

            listaMarca = Planilha.RetornaListaMarcasPlanilha("C:\\GIT\\GitC\\TrabalhoFinalApi\\TrabalhoFinalApi\\Arquivos\\MarcasVeiculos.csv", 1);

            foreach (var item in listaMarca)
            {
                context.marcas.Add(item);
            }

            listaMarca = Planilha.RetornaListaMarcasPlanilha("C:\\GIT\\GitC\\TrabalhoFinalApi\\TrabalhoFinalApi\\Arquivos\\MarcaMotos.csv", 2);

            foreach (var item in listaMarca)
            {
                context.marcas.Add(item);
            }

            
            context.SaveChanges();

            var listaModelo = new List<Modelo>();

            listaModelo = Planilha.RetornaListaModeloPlanilha("C:\\GIT\\GitC\\TrabalhoFinalApi\\TrabalhoFinalApi\\Arquivos\\ModeloVeiculos.csv",1);

            foreach (var item in listaModelo)
            {
                context.modelos.Add(item);
            }

            listaModelo = Planilha.RetornaListaModeloPlanilha("C:\\GIT\\GitC\\TrabalhoFinalApi\\TrabalhoFinalApi\\Arquivos\\ModeloMotos.csv",2);

            foreach (var item in listaModelo)
            {
                context.modelos.Add(item);
            }

            context.SaveChanges();

            var listaCor = new List<Cor>();

            listaCor.Add(new Cor() { Descricao = "Branco" });
            listaCor.Add(new Cor() { Descricao = "Preto" });
            listaCor.Add(new Cor() { Descricao = "Prata" });
            listaCor.Add(new Cor() { Descricao = "Cinza" });
            listaCor.Add(new Cor() { Descricao = "Vermelho" });
            listaCor.Add(new Cor() { Descricao = "Marrom/Bege" });
            listaCor.Add(new Cor() { Descricao = "Azul" });
            listaCor.Add(new Cor() { Descricao = "Verde" });
            listaCor.Add(new Cor() { Descricao = "Amarelo/Dourado" });
            listaCor.Add(new Cor() { Descricao = "Outras" });

            foreach (var item in listaCor)
            {
                context.cores.Add(item);

            }

            context.SaveChanges();

        }
    }
}
