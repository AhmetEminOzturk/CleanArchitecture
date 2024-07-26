using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Authorization
{
    public sealed class RoleFilterAttribute : TypeFilterAttribute
    {
        public RoleFilterAttribute(string role) : base(typeof(RoleAttribute))
        {
            Arguments = new object[] { role };
        }
    }
}
