using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bucaqlar
{
    class coxBucaq
    {
                protected int teref; 

            public coxBucaq (int teref)
            {
                this.teref = teref;
            }
        public virtual int Sahe()
        {
            return teref;
        }
    }
    class dordBucaq : coxBucaq
    {
        public dordBucaq(int teref) : base(teref) {

        }
        public override int Sahe()
        {
            return teref * 4;
        }
    }

    class ucBucaq : coxBucaq
    {
        public ucBucaq(int teref) : base(teref) { }

        public override int Sahe()
        {
            return teref * 3;
        }
    }
}

