using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bookapi.Books.DeleteBook
{
    public class DeleteBookEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/books/{id}", async ([FromRoute] int id,ISender sender) => {


                var result = await sender.Send(new DeleteBookCommand { Id=id});
                return Results.Ok(result);
                
            });
        }
    }
}
