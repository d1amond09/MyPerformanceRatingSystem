﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PerformanceRatingSystem.Domain.Entities;
using System.Threading.Tasks;

namespace PerformanceRatingSystem.WebMVC.Areas.Identity.Pages.Account.Manage;

[Authorize]
public class PersonalDataModel : PageModel
{
    private readonly UserManager<User> _userManager;
    private readonly ILogger<PersonalDataModel> _logger;

    public PersonalDataModel(
        UserManager<User> userManager,
        ILogger<PersonalDataModel> logger)
    {
        _userManager = userManager;
        _logger = logger;
    }

    public async Task<IActionResult> OnGet()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return NotFound($"Невозможно загрузить пользователя с ID '{_userManager.GetUserId(User)}'.");
        }

        return Page();
    }
}