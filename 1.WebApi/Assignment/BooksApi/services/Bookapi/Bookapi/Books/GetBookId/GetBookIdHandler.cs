using Bookapi.Data;
using Bookapi.Model;
using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Bookapi.Books.GetBookId
{

    public class GetBookIdQuery:IRequest<Book>
    {
        public int Id { get; set; }
    }

    
    public class GetBookIdHandler : IRequestHandler<GetBookIdQuery, Book>
    {

        readonly ProductContext _context;

        public GetBookIdHandler(ProductContext context)
        {
            _context = context;
        }
        public async Task<Book> Handle(GetBookIdQuery request, CancellationToken cancellationToken)
        {

            var book =  await _context.Books.FirstOrDefaultAsync(x=>x.Id == request.Id);

            return book;
        }
    }
}
