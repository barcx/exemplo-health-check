﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HealthCheck.Pages;

public class IndexModel : PageModel
{
    public IActionResult OnGet()
    {
        return Redirect("~/health");
    }
}