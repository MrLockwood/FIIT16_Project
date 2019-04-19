using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracer
{
    class Bug
    {
        private int code;
        private string title;
        private string type;
        private string description;
        public int GetCode()
        {
            int _code = code;
            return _code;
        }
        public string GetTitle()
        {
            string _title = title;
            return _title;
        }
        public string GetType()
        {
            string _type = type;
            return _type;
        }
        public string GetDescription()
        {
            string _description = description;
            return _description;
        }
        public void SetCode(int _code)
        {
            code = _code;
        }
        public void SetTitle(string _title)
        {
            title = _title;
          
        }
        public void SetType(string _type)
        {
            type = _type;
        }
        public void SetDescription(string _description)
        {
            description = _description;
        }
    }
}
