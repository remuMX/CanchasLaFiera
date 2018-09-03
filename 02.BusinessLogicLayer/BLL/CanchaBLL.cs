using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CanchaBLL
    {
        private CanchaDAL canchaDAL = CanchaDAL.Instance();

        private static volatile CanchaBLL instance = null;
        private static readonly object padlock = new object();

        private CanchaBLL() { }

        public static CanchaBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new CanchaBLL();
            return instance;
        }

        public Canchas GetAll()
        {
            return canchaDAL.GetAll();
        }
    }
}
