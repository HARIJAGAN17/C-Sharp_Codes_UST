using Bookapi.Data;
using Bookapi.Model;
using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Bookapi.Books.CreateBook
{

    public class CreateBookCommand:IRequest<int>
    {

        public string Title { get; set; }

        public string Author { get; set; }

        public double Price { get; set; }
    }
    public class CreateBookHandler : IRequestHandler<CreateBookCommand, int>
    {
        readonly ProductContext _context;
        public CreateBookHandler(ProductContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var singleProduct = request.Adapt<Book>();

            var isCreated = await _context.Books.AddAsync(singleProduct);
            await _context.SaveChangesAsync();

            return singleProduct.Id;
        }
    }
}
