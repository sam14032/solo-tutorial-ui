using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Solo.Domain.SoloRepository;

namespace Solo.API.Commands
{
    public class GetArticleHandler : IRequestHandler<GetArticle, IActionResult>
    {
        public ISoloRepository _repository;
        public GetArticleHandler(ISoloRepository repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> Handle(GetArticle request, CancellationToken cancellationToken)
        {
            var article = await _repository.GetArticle(request.Article.Id);
            return new OkObjectResult(article);
        }
    }
}