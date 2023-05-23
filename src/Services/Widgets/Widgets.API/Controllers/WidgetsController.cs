using Microsoft.AspNetCore.Mvc;

namespace Widgets.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class WidgetsController : ControllerBase
    {
        private readonly ILogger<WidgetsController> _logger;

        public WidgetsController(ILogger<WidgetsController> logger)
        {
            _logger = logger;
        }
    }
}