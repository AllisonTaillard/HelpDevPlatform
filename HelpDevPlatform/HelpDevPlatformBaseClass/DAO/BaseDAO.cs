using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDevPlatformBaseClass.DAO
{
    public abstract class BaseDAO<T>
    {
        protected static SqlCommand _command;
        protected static SqlConnection _connection;
        protected static SqlDataReader _reader;
        protected static string _request;

        public abstract int Create(T element);

        public abstract (bool, int) Delete(T element);

        public abstract bool Delete(int id);

        public abstract (bool, int) Update(T element);

        public abstract (bool, T) Find(int index);

        public abstract (bool, ObservableCollection<T>) Find(Func<T, bool> critere);

        public abstract ObservableCollection<T> FindAll();
    }
}
