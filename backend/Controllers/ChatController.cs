using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/chat")]
    public class ChatController : ControllerBase
    {
        [HttpPost]
        public IActionResult Chat([FromBody] ChatRequest request)
        {
            return Ok(new
            {
                response = $"You said: {request.Message}"
            });
        }
    }

    public class ChatRequest
    {
        public required string Message { get; set; }
    }
}