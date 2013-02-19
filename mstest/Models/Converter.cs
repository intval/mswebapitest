using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mstest.Models
{
    public static class Converter
    {
        public static ReducedUserModel toReduced(this User model)
        {
            return new ReducedUserModel
            {
                Name = model.Name
            };
        }
    }
}