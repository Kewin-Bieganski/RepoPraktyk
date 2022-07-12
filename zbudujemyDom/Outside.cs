using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zbudujemyDom
{
    internal class Outside : Location
    {
        private bool hot;
        public override string Description
        {
            get
            {
                string NewDescription = base.Description;
                if(hot)
                {
                    NewDescription += " Tutaj jest bardzo gorąco.";
                }
                return NewDescription;
            }
        }
        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }
    }
}
