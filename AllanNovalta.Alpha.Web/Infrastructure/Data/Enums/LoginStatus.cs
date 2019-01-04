using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllanNovalta.Alpha.Web.Infrastructure.Data.Enums
{
    public enum LoginStatus
    {
        Unverified,
        Active,
        Locked,
        NeedsToChangePassword
    }
}
