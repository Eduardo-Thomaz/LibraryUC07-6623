using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Biblioteca.Models
{
    public class UsuarioService
    {
        public void incluirUsuario(Usuario novoUsuario) {

            using(BibliotecaContext bc = new BibliotecaContext()) {

                bc.Usuarios.Add(novoUsuario);
                bc.SaveChanges();
            }
        }

        public void excluirUsuario(int Id) {

            using(BibliotecaContext bc = new BibliotecaContext()) {

                bc.Usuarios.Remove(bc.Usuarios.Find(Id));
                bc.SaveChanges();
            }
        }

        public void editarUsuario (Usuario u) {

            using(BibliotecaContext bc = new BibliotecaContext()) {

                Usuario user = bc.Usuarios.Find(u.Id);

                user.Login = u.Login;
                user.Nome = u.Nome;
                user.Senha = u.Senha;
                user.Tipo = u.Tipo;
                bc.SaveChanges();
                
            }
        }

        public List<Usuario> Listar() {

            using(BibliotecaContext bc = new BibliotecaContext()) {

                return bc.Usuarios.ToList();

            }

        }

        public Usuario Listar(int Id) {

            using(BibliotecaContext bc = new BibliotecaContext()) {

                return bc.Usuarios.Find(Id);

            }

        }
    }
}