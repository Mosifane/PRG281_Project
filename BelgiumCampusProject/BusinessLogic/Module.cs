/*
Oratile Hlatshwayo - 577279
Omphile Tladi - 577776
Mosifane Mosifane - 577306
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgiumCampusProject.BusinessLogic
{
    internal class Modules
    {
        string moduleCode, moduleName, moduleDescription;
        public string ModuleCode { get { return moduleCode; } }
        public string ModuleName { get { return moduleName; } }
        public string ModuleDescription { get { return moduleDescription; } }

        public Modules(string moduleCode, string moduleName, string moduleDescription)
        {
            this.moduleCode = moduleCode;
            this.moduleName = moduleName;
            this.moduleDescription = moduleDescription;
        }
    }
}
