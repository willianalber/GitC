﻿using System;
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
using TCC_API_Locadora_Garagem.Models;

namespace TCC_API_Locadora_Garagem.Controllers
{
    public class TiposVeiculosController : ApiController
    {
        private BaseDeDados db = new BaseDeDados();

        // GET: api/TiposVeiculos
        public IQueryable<TipoVeiculo> GettipoVeiculos()
        {
            return db.tipoVeiculos;
        }

        // GET: api/TiposVeiculos/5
        [ResponseType(typeof(TipoVeiculo))]
        public async Task<IHttpActionResult> GetTipoVeiculo(int id)
        {
            TipoVeiculo tipoVeiculo = await db.tipoVeiculos.FindAsync(id);
            if (tipoVeiculo == null)
            {
                return NotFound();
            }

            return Ok(tipoVeiculo);
        }

        // PUT: api/TiposVeiculos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTipoVeiculo(int id, TipoVeiculo tipoVeiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipoVeiculo.Id)
            {
                return BadRequest();
            }

            db.Entry(tipoVeiculo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoVeiculoExists(id))
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

        // POST: api/TiposVeiculos
        [ResponseType(typeof(TipoVeiculo))]
        public async Task<IHttpActionResult> PostTipoVeiculo(TipoVeiculo tipoVeiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tipoVeiculos.Add(tipoVeiculo);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = tipoVeiculo.Id }, tipoVeiculo);
        }

        // DELETE: api/TiposVeiculos/5
        [ResponseType(typeof(TipoVeiculo))]
        public async Task<IHttpActionResult> DeleteTipoVeiculo(int id)
        {
            TipoVeiculo tipoVeiculo = await db.tipoVeiculos.FindAsync(id);
            if (tipoVeiculo == null)
            {
                return NotFound();
            }

            db.tipoVeiculos.Remove(tipoVeiculo);
            await db.SaveChangesAsync();

            return Ok(tipoVeiculo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipoVeiculoExists(int id)
        {
            return db.tipoVeiculos.Count(e => e.Id == id) > 0;
        }
    }
}