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

namespace TrabalhoFinalApi.Controllers
{
    public class TermoLocacaosController : ApiController
    {
        private ContextDb db = new ContextDb();

        // GET: api/TermoLocacaos
        public IQueryable<TermoLocacao> GettermosLocacoes()
        {
            return db.termosLocacoes.Where(x => x.Ativo == true);
        }

        // GET: api/TermoLocacaos/5
        [ResponseType(typeof(TermoLocacao))]
        public async Task<IHttpActionResult> GetTermoLocacao(int id)
        {
            TermoLocacao termoLocacao = await db.termosLocacoes.FindAsync(id);
            if (termoLocacao == null)
            {
                return NotFound();
            }

            return Ok(termoLocacao);
        }

        // PUT: api/TermoLocacaos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTermoLocacao(int id, TermoLocacao termoLocacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != termoLocacao.Id)
            {
                return BadRequest();
            }

            validaTextVigente(termoLocacao);    
            
            //db.Entry(termoLocacao).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TermoLocacaoExists(id))
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
        
        private void validaTextVigente(TermoLocacao termoLocacao)
        {
            foreach (var item in db.termosLocacoes)
            {
                if (item.Descricao != termoLocacao.Descricao)
                {
                    db.termosLocacoes.Find(item.Id).Ativo = false;

                    if (item.Id == termoLocacao.Id)
                    {
                        db.termosLocacoes.Add(termoLocacao);
                    }
                }
            }

        }

        // POST: api/TermoLocacaos
        [ResponseType(typeof(TermoLocacao))]
        public async Task<IHttpActionResult> PostTermoLocacao(TermoLocacao termoLocacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            validaTextVigente(termoLocacao);

            db.termosLocacoes.Add(termoLocacao);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = termoLocacao.Id }, termoLocacao);
        }

        // DELETE: api/TermoLocacaos/5
        [ResponseType(typeof(TermoLocacao))]
        public async Task<IHttpActionResult> DeleteTermoLocacao(int id)
        {
            TermoLocacao termoLocacao = await db.termosLocacoes.FindAsync(id);
            if (termoLocacao == null)
            {
                return NotFound();
            }

            db.termosLocacoes.Remove(termoLocacao);
            await db.SaveChangesAsync();

            return Ok(termoLocacao);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TermoLocacaoExists(int id)
        {
            return db.termosLocacoes.Count(e => e.Id == id) > 0;
        }
    }
}