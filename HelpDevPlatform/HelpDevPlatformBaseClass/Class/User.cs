using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDevPlatformBaseClass.Class
{
    internal class User
    {
        /* Les Users peuvent:
         * - créer un topic
         * - créer un compte user
         * - se connecter à un compte user
         * - modifier son propre compte user
         * - créer un message dans un topic
         */

        private int userId;
        private string username;
        private string password;
        private string firstname;
        private string lastname;
        // à voir pour l'adresse


        public User()
        {

        }

        public User(string username, string password, string firstname, string lastname)
        {
            Username = username;
            Password = password;
            Firstname = firstname;
            Lastname = lastname;
        }

        public User(int userId, string username, string password, string firstname, string lastname)
        {
            UserId = userId;
            Username = username;
            Password = password;
            Firstname = firstname;
            Lastname = lastname;
        }

        public int UserId { get => userId; set => userId = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
    }
}
