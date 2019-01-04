using AllanNovalta.Alpha.Web.Infrastructure.Data.Helpers;
using AllanNovalta.Alpha.Web.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllanNovalta.Alpha.Web.Areas.Manage.ViewModels.Users
{
    public class IndexViewModel
    {
        public Page<User> Users { get; set; }

    }
}
