using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Biblioteca.Models;
using System.Linq;

namespace Biblioteca.Controllers
{
    public class Autenticacao
    {
        public static void CheckLogin(Controller controller)
        {   
            if(string.IsNullOrEmpty(controller.HttpContext.Session.GetString("login")))
            {
                controller.Request.HttpContext.Response.Redirect("/Home/Login");
            }
        }

        public static bool VerificaLoginSenha(string login, string senha, Controller controller) {

            using(BibliotecaContext bc = new BibliotecaContext()) {

                VerificaSeUsuarioAdminExiste(bc);

                //nesta linha será armazenada a senha com HASH MD5
                senha = Criptografia.TextCriptografado(senha);

                //IQueryable<Usuario> UsuarioEncontrado = bc.Usuarios.Where( u => u.Login == login && u.Senha == senha).ToList();
                IQueryable<Usuario> UsuarioEncontrado = bc.Usuarios.Where( u => u.Login == login && u.Senha == senha);
                List<Usuario> UsuariosEncontrados = UsuarioEncontrado.ToList();

                if (UsuariosEncontrados.Count == 0) {

                    return false;

                }
                else {
                    
                    controller.HttpContext.Session.SetString("login", UsuariosEncontrados[0].Login);
                    controller.HttpContext.Session.SetString("nome", UsuariosEncontrados[0].Nome);
                    controller.HttpContext.Session.SetInt32("tipo", UsuariosEncontrados[0].Tipo);

                    return true;
                }
            }

        }

        public static void VerificaSeUsuarioAdminExiste(BibliotecaContext bc) {

            IQueryable<Usuario> UsuarioEncontrado = bc.Usuarios.Where( u => u.Login == "admin");

            if(UsuarioEncontrado.ToList().Count == 0) {

                Usuario admin = new Usuario();
                admin.Nome = "Administrador";
                admin.Login = "admin";
                admin.Senha = Criptografia.TextCriptografado("123");
                admin.Tipo = Usuario.ADMIN;

                bc.Usuarios.Add(admin);
                bc.SaveChanges();

            }

        }

        public static void VerificaSeUsuarioEAdmin(Controller controller) {
            
            if(!(controller.HttpContext.Session.GetInt32("tipo") == Usuario.ADMIN)) {

                controller.Request.HttpContext.Response.Redirect("/Usuario/NeedAdmin");

            }
        }
        
    }
}