// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RazorOutputFormatterExample.Models;
using System.Linq;
using System;

namespace RazorOutputFormatterExample.Controllers
{
    [FormatFilter]
    [Route("api/[controller]")]
    public class GargoylesController : Controller
    {
        [HttpGet("~/api/{_:regex(^(gargoyles)$)}.{format?}")]
        public IEnumerable<Gargoyle> Get() => 
            Gargoyle.GetAll();

        [HttpGet("{name}.{format?}")]
        public Gargoyle Get(string name) =>
            Gargoyle.GetAll()
                .FirstOrDefault(g => g.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
}
