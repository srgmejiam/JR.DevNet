using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
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
        public static bool ValidarUserName(string username)
        {
            username = DeleteSqlInjection(username);
            using var db = new BD();
            return db.Usuarios.Any(u => u.UserName.ToUpper() == username.ToUpper());
        }
        public static bool ValidarPassword(string username, string password)
        {
            username = DeleteSqlInjection(username);
            password = DeleteSqlInjection(password);
            var passwordHash = System.Security.Cryptography.SHA256.HashData(Encoding.UTF8.GetBytes(password));
            //updatePassword();
            using var db = new BD();
            return db.Usuarios.Any(u => u.UserName.ToUpper() == username.ToUpper() && u.Password == passwordHash);
        }
        public static bool updatePassword()
        {
            using var db = new BD();
            var user = db.Usuarios.FirstOrDefault(u => u.UserName == "admin");
            user.Password = System.Security.Cryptography.SHA256.HashData(Encoding.UTF8.GetBytes("Abc"));
            db.SaveChanges();
            return true;
        }

        public static bool IntentosFallidos(string username)
        {
            using var db = new BD();
            var user = db.Usuarios.SingleOrDefault(u => u.UserName == username);
            if (user != null)
            {
                if(user.Intentos < Parametros.IntentosFallidos())
                {
                    user.Intentos++;
                    db.SaveChanges();
                    return true;
                }
                user.Bloqueado = true;
                db.SaveChanges();
                return false;
            }
            return false;
        }
        public static bool UsuarioBloqueado(string username)
        {
            using var db = new BD();
            var user = db.Usuarios.SingleOrDefault(u => u.UserName == username);
            if (user != null)
            {
                return user.Bloqueado;
            }
            return true;
        }







        public static string DeleteSqlInjection(string input)
        {
            var sqlInjectionPatterns = new[] { "--", ";--", ";", "/*", "*/", "@@", "@" };
            foreach (var pattern in sqlInjectionPatterns)
            {
                input = input.Replace(pattern, string.Empty);
            }
            return input;
        }

    }
}
