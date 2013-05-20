using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using MLApp;

namespace AutoFigPro
{
    class MatlabModule
    {
//        private MLAppClass matlabInst;
        private String strCmd;
        public String StrCmd
        {
            get { return strCmd; }
            set { strCmd = value; }
        }
        public MatlabModule()
        {
//            matlabInst = new MLAppClass();
        }
        public void Execute()
        {
//            matlabInst.Execute(strCmd);
        }
    }
}
