using Carter;
using MediatR;

namespace Bookapi.Books.UpdateBook
{
    public class UpdateBookEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPut("/books", async (UpdateBookCommand req,ISender sender) => {

                var result = await sender.Send(req);
                return Results.Ok(result);
            });
        }
    }
}
