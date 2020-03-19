using System;
using System.Collections.Generic;
using System.Text;
using UseYourIllusion.Core.Data;

namespace UseYourIllusion.Core.Services
{
    public abstract class Base
    {

        protected UseYourIllusionDbContext _context; 

        public Base(UseYourIllusionDbContext context)
        {
            _context = context;
        }
    }
}
