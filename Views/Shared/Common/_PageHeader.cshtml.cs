using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Blogger.Views.Shared.Common
{
    public class _PageHeader : PageModel
    {
        private readonly ILogger<_PageHeader> _logger;

        public _PageHeader(ILogger<_PageHeader> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}