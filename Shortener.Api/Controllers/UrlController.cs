using Microsoft.AspNetCore.Mvc;

namespace Shortener.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UrlController : ControllerBase
{

    private readonly ILogger<UrlController> _logger;

    public UrlController(ILogger<UrlController> logger)
    {
        _logger = logger;
    }
    
}