using System;
using System.Collections.Generic;

namespace Optimum
{
    [Serializable]
    public class Data
    {
        public string Function { get; set; }
        public List<string> VarName { get; set; }
        public List<double> VarValue { get; set; }
        public Data(string Function, List<string> VarName, List<double> VarValue)
        {
            this.Function = Function;
            this.VarName = VarName;
            this.VarValue = VarValue;
        }
        public Data() { }
    }
}
