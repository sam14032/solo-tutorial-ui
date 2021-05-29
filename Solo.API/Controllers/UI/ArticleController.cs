using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solo.API.Commands;
using Solo.API.Models.UI.ArticleAggregate.Write;

namespace Solo.API.Controllers.UI
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class ArticleController : ControllerBase
    {
        private readonly ILogger<ArticleController> _logger;
        private IMediator _mediator;

        public ArticleController(IMediator mediator, ILogger<ArticleController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        /// <summary>
        /// Get article from id.
        /// </summary>
        /// <response code="200">Return corresponding article.</response>
        /// <response code="404">Article not found</response>
        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(Article),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(long id)
        {
            _logger.LogDebug($"Get article {id}");
            return await _mediator.Send(new GetArticle(id));
        }
        
    }
}