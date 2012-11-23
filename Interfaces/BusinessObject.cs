using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public abstract class BusinessObject
    {
        public List<BusinessObject> GetAll(Dictionary<String, Object> Params)
        {
            return new List<BusinessObject>();
        }
    }
}
