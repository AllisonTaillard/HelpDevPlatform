using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HelpDevPlatformBaseClass.Class
{
    internal class Data // pour la persistance des données sans BDD
    {
        private List<User> users;
        private List<Topic> topics;
        private List<Message> messages;

        public Data()
        {
            users = new();
            topics = new();
            messages = new();
        }

        internal List<User> Users { get => users; set => users = value; }
        internal List<Topic> Topics { get => topics; set => topics = value; }
        internal List<Message> Messages { get => messages; set => messages = value; }

        public void Init()
        {
            // créer fake Users, Topics, Messagges
        }

        public bool AddUser(User u)
        {
            int nb1 = users.Count;
            users.Add(u);
            int nb2 = topics.Count;
            return nb2 - nb1 == 1;
        }

        public bool AddTopic(Topic t)
        {
            int nb1 = users.Count;
            topics.Add(t);
            int nb2 = topics.Count;
            return nb2 - nb1 == 1;
        }

        public User FindUser(int id)
        {
            return users.Find(u => u.UserId == id);
        }
    }
}
