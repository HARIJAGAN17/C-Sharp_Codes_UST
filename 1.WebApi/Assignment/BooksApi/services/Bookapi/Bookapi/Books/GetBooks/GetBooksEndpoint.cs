using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bookapi.Books.GetBooks
{
    public class GetBooksEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/books", async (ISender sender) => {
                
                var result = await sender.Send(new GetBooksQuery());
                
                return Results.Ok(result);
            });
        }
    }
}
