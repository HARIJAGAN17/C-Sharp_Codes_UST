using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;

namespace Bookapi.Books.GetBookId
{
    public class GetBookIdEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/books/{id}", async ([FromRoute] int id,ISender sender) => {
            

                var query = new GetBookIdQuery { Id = id };
                var reuslt = await sender.Send(query);

                if(reuslt != null)
                {
                    return Results.Ok(reuslt);
                }
                return Results.NotFound("book not exist");
            });
        }
    }
}
