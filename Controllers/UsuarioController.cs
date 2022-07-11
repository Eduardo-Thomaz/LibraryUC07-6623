using Biblioteca.Models;
// using Biblioteca.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class UsuarioController : Controller
    {
        
        public IActionResult CadastrarUsuario() {

            Autenticacao.CheckLogin(this);
            Autenticacao.VerificaSeUsuarioEAdmin(this);

            return View();
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(Usuario u) {

            u.Senha = Criptografia.TextCriptografado(u.Senha);

            new UsuarioService().incluirUsuario(u);

            return RedirectToAction("ListarUsuario");
        }

        public IActionResult ExcluirUsuario (int Id) {

            Autenticacao.CheckLogin(this);
            Autenticacao.VerificaSeUsuarioEAdmin(this);

            return View(new UsuarioService().Listar(Id));

        }

        [HttpPost]
        public IActionResult ExcluirUsuario (string decision, int Id) {

            if(decision == "EXCLUIR") {

                ViewData["mensagem"] = "Usuário " + new UsuarioService().Listar(Id).Nome + " excluído com sucesso!";
                new UsuarioService().excluirUsuario(Id);

                return View("ListarUsuario", new UsuarioService().Listar());
            }
            
            else {

                ViewData["mensagem"] = "Usuário " + new UsuarioService().Listar(Id).Nome + "não deletado!";

                return View("ListarUsuario", new UsuarioService().Listar());

            }

        }

        public IActionResult ListarUsuario() {

            Autenticacao.CheckLogin(this);
            Autenticacao.VerificaSeUsuarioEAdmin(this);

            return View(new UsuarioService().Listar());

        }

        public IActionResult EditarUsuario (int Id) {

            Autenticacao.CheckLogin(this);
            Autenticacao.VerificaSeUsuarioEAdmin(this);

            return View(new UsuarioService().Listar(Id));

        }

        [HttpPost]
        public IActionResult EditarUsuario (Usuario u) {

            new UsuarioService().editarUsuario(u);

            return RedirectToAction("ListarUsuario");
        }

        public IActionResult NeedAdmin() {

            Autenticacao.CheckLogin(this);
            // Autenticacao.VerificaSeUsuarioEAdmin(this);

            return View();
        }

        public IActionResult Logout () {

            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");

        }
    }
}