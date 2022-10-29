using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machinedata.Shared
{
    public class Measurment
    {
        public string Name { get; set; }
        public int MId { get; set; }
        public MeasurmentType measurmentType { get; set; }
        public DateTime time { get; set; }
        public Module module { get; set; }
    }


    public class Module
    {
        public string moduleName { get; set; }
        public int moduleId { get; set; }
    }

    public class MeasurmentType
    {
        public string MTName { get; set; }
        public int id { get; set; }
    }

    //public class Platform
    //{
    
    //}

    public class DBClasses : 
}
