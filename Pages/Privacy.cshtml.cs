using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace tempdata_cookie_redirect.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
			TempData["tempdata-redirect-test"] = "hi " + new Random().Next();
        }
		
		public IActionResult OnPost()
		{
			var _ = TempData["tempdata-redirect-test"];
			return RedirectToPage("/Index");
		}
    }
}
