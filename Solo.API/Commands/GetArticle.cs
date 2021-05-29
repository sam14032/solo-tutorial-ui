using MediatR;
using Microsoft.AspNetCore.Mvc;
using Solo.API.Models.UI.ArticleAggregate.Read;

namespace Solo.API.Commands
{
    public class GetArticle : IRequest<IActionResult>
    {
        public Article Article { get; set; } 

        public GetArticle(long id)
        {
            Article = new Article(id);
        }
    }
}