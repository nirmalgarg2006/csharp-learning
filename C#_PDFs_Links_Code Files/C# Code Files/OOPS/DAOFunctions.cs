using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp.OOPS
{
    interface DAOFunctions
    {       
        void insert();
        void update();
        void delete();
    }
    interface DDLFunction:DAOFunctions
    {
        void create();
        void drop();
    }
}
