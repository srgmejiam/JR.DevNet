using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public static class Usuarios
    {
        public static List<EL.Usuarios> GetUsuarios()
        {
            using var db = new BD();
            return [.. db.Usuarios];
        }

    }
}
