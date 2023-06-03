using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Planner.Models;

namespace Planner.Controllers.auth;

public class AuthController
{
    private readonly ILogger<HomeController> _logger;

    public AuthController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public void RegisterUser()
    {
        
    }
    
    [HttpPost]
    public void LoginUser()
    {
        
    }
    
    [HttpPatch]
    public void EditUser()
    {
        
    }
    
    [HttpDelete]
    public void DeleteUser()
    {
        
    }
    
}