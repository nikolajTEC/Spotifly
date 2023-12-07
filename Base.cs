using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifly
{
    public abstract class Base
    {
        private string _user;
        private DateTime _created;

        public string User { get => _user; set => _user = value; }
        public DateTime Created { get => _created; set => _created = value; }   
    }
}
