using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Solo.API.Commands
{
    public class GetArticleHandler : IRequestHandler<GetArticle, IActionResult>
    {
        public Task<IActionResult> Handle(GetArticle request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}