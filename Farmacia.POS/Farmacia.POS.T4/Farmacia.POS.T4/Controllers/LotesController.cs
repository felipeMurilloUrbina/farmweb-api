using Farmacia.POS.BLL;
using Farmacia.POS.DAO;
using Farmacia.POS.Model;
using Farmacia.POS.WebApi.Infrastructure;
using Farmacia.POS.WebApi.Models;
using Farmacia.POS.WebApi.Properties;
using Microsoft.AspNet.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;

namespace Farmacia.POS.WebApi.Controllers
{
    [RoutePrefix("api/lotes")]
    public class LotesController : BaseApiController
    {
        readonly ServicioLote _servicio = null;
        Contexto _contexto = null;
        string _element = "Lote";
        public LotesController(): base()
        {
            _contexto = new Contexto();
            var repository = new LoteRepository(_avikaDB, _logger);
            this._servicio = new ServicioLote(repository);
        }
        /// <summary>
        /// Get {Lotes}
        /// </summary>
        /// <returns>List of Lotes </returns>
        [Route(""), HttpGet]
        public async Task<IHttpActionResult> Get([FromUri]int? page = null, [FromUri] int? qty = null)
        {
            page = page == null || page == 0 ? 1 : page;
            qty = qty ?? 0;
            return Ok(this._servicio.Get(page, qty).Result);
        }
        /// <summary>
        /// Get {category}
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Lotes </returns>
        [HttpGet]
        public async Task<IHttpActionResult> GetId(int id)
        {
            return Ok(_servicio.Get(id));
        }
        /// <summary>
        /// Post to Lotes
        /// </summary>
        /// <param name="Lotes"></param>
        /// <returns></returns>
        [Route(""), CustomAuthorize(Role = "Administrador"), HttpPost]
        public async Task<IHttpActionResult> Post(LoteDto lotes)
        {
            if (category == null)
                return BadRequest(String.Format(Resources.RequestEmpty, _element));
            var principal = RequestContext.Principal as ClaimsPrincipal;
            category.UserCreatorId = principal.Identity.GetUserId();
            category.UserModificatorId = principal.Identity.GetUserId();
            var res = this._servicio.Post(category).Result;
            if (res > 0)
                return Ok(String.Format(Resources.SaveOk, _element));
            else
                return BadRequest(String.Format(Resources.SaveError, _element));
        }
        /// <summary>
        /// Update {category}
        /// </summary>
        /// <retuns></returns>
        [Route(""), CustomAuthorize(Role = "Administrador"), HttpPut]
        public async Task<IHttpActionResult> Put(LoteDto lotes)
        {
            if (category == null)
                return BadRequest(String.Format(Resources.RequestEmpty, _element));
            var principal = RequestContext.Principal as ClaimsPrincipal;
            category.UserModificatorId = principal.Identity.GetUserId();
            var res = this._servicio.Put(category).Result;
            switch (res)
            {
                case -1:
                    return BadRequest(String.Format(Resources.UpdateError, _element));
                default:
                    return Ok(String.Format(Resources.UpdateOk, _element));
            }

        }
        /// <summary>
        /// Borrar {Lotes}
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [Route("{id}"), CustomAuthorize(Role = "Administrador"), HttpDelete]
        public async Task<IHttpActionResult> Delete(int id)
        {
            var res = this._servicio.Delete(id).Result;
            if (res > 0)
            {
                return Ok(String.Format(Resources.DeleteOk, _element));
            }
            else
            {
                return BadRequest(String.Format(Resources.DeleteError, _element));
            }
        }
    }
}

