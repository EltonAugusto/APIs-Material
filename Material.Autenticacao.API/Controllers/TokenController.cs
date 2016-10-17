using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Material.Autenticacao.API.Controllers
{
    [RoutePrefix("api/v1")]
    public class TokenController : ApiController
    {
        [HttpGet]
        [Authorize]
        [Route("ValidateToken")]
        public bool ValidateToken()
        {
            return true;
        }
    }
}
