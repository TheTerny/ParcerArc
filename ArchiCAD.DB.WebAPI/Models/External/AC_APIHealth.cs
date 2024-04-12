using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArchiCAD.DB.WebAPI.Models.External
{
    public class AC_APIHealth_Response
    {
        public bool succeeded { get; set; }
        public AC_APIHealth_Result result { get; set; }
    }

    public class AC_APIHealth_Result
    {
        public bool isAlive { get; set; }
    }
}
