using Ingenio.Business;
using Ingenio.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Ingenio.Api
{
    public class UsuarioController : ApiController
    {
        private readonly UsuarioBLL _usuarioBLL;

        public UsuarioController()
        {
            _usuarioBLL = new UsuarioBLL();
        }

        public UsuarioController(UsuarioBLL usuarioBLL)
        {
            _usuarioBLL = new UsuarioBLL();
        }

        [HttpPost]
        public async Task<bool> Loguear([FromBody] Usuario usuario)
        {
            var user = await _usuarioBLL.Loguear(usuario);
            return user;
        }

    }
}