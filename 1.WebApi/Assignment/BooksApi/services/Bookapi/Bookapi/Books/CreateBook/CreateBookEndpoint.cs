using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bookapi.Books.CreateBook
{

    public class CreateBookEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/books", async ([FromBody] CreateBookCommand req, ISender sender) => {


                var result = await sender.Send(req);
                return Results.Created($"/books/{result}", result);
            });
        }
    }
}
