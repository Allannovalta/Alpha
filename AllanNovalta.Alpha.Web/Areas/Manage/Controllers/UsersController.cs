﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllanNovalta.Alpha.Web.Infrastructure.Data.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace AllanNovalta.Alpha.Web.Areas.Manage.Controllers
{
    public class UsersController : Controller
    {
        private readonly DefaultDbContext _context;

        public UsersController(DefaultDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var users = this._context.Users.ToList();
            return View();
        }
    }
}