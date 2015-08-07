using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBACManager
{
    public class MysqlModel
    {
        public MysqlModel() { }

        public string Host
        {
            get;
            set;
        }

        public ushort Port
        {
            get;
            set;
        }

        public string User
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public string Database
        {
            get;
            set;
        }
    }
}
