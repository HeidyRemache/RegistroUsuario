using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroUsuario
{
    public class ListaUsuarios
    {
        public List<Usuario> Usuarios { set; get; }

        public ListaUsuarios()
        {
            Usuarios = new List<Usuario>();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }
    }
}
