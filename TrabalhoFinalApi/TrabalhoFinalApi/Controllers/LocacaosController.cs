using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using TrabalhoFinalApi.Models;
using TrabalhoFinalApi.Enuns;
using System.ComponentModel.DataAnnotations;

namespace TrabalhoFinalApi.Controllers
{
    public class LocacaosController : ApiController
    {
        private ContextDb db = new ContextDb();

        // GET: api/Locacaos
        public IQueryable<Locacao> Getlocacaos()
        {
            return db.locacaos.Where(x=>x.Ativo==true);
        }

        // GET: api/Locacaos/5
        [ResponseType(typeof(Locacao))]
        public async Task<IHttpActionResult> GetLocacao(int id)
        {
            Locacao locacao = await db.locacaos.FindAsync(id);
            if (locacao == null)
            {
                return NotFound();
            }

            return Ok(locacao);
        }

        // PUT: api/Locacaos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLocacao(int id, Locacao locacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != locacao.Id)
            {
                return BadRequest();
            }

            db.Entry(locacao).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocacaoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }
        private int retornaUltimoIdVeiculo()
        {
            int id = 0;
            foreach (var item in db.veiculos)
            {
                id = item.Id;
            }
            return id;
        }
        // POST: api/Locacaos
        [ResponseType(typeof(Locacao))]
        public async Task<IHttpActionResult> PostLocacao(int prTipoVeiculo, int prPeriodo, int prColaborador, bool prTermo, int prMarca = 0, int prModelo = 0, int prCor = 0, string prPlaca = "", bool prCarona = false, bool prOutraCidade = false)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            VeiculoesController veiculoPost = new VeiculoesController();
            
            
            Veiculo veiculo = new Veiculo() { Colaborador = prColaborador, IdCor = prCor, Marca = prMarca, IdModelo = prModelo, Placa = prPlaca };
            var TermoAtivo = db.termosLocacoes.FirstOrDefault(x => x.Ativo == true);
            
            if (!prTermo)
            {
                return NotFound();
            }

            if (!veiculoPost.PostVeiculo(veiculo).IsCompleted)
            {
                int idV = retornaUltimoIdVeiculo();
                Locacao locacao = new Locacao()
                {
                    IdColaborador = prColaborador,
                    IdVeiculo = idV,
                    IdPeriodoLocacao = prPeriodo,
                    IdTermoLocacao = TermoAtivo.Id,
                    OfereceCarona = prCarona,
                    ResideFora = prOutraCidade,
                    IdSituacao = 1
                };
                    
            

                db.locacaos.Add(locacao);
                await db.SaveChangesAsync();

                return CreatedAtRoute("DefaultApi", new { id = locacao.Id }, locacao);
            }

            return NotFound();

            
        }
        

        // DELETE: api/Locacaos/5
        [ResponseType(typeof(Locacao))]
        public async Task<IHttpActionResult> DeleteLocacao(int id)
        {
            Locacao locacao = await db.locacaos.FindAsync(id);
            if (locacao == null)
            {
                return NotFound();
            }

            db.locacaos.Remove(locacao);
            await db.SaveChangesAsync();

            return Ok(locacao);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LocacaoExists(int id)
        {
            return db.locacaos.Count(e => e.Id == id) > 0;
        }
    }
}