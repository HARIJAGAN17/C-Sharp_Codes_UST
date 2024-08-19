using Bookapi.Data;
using Bookapi.Model;
using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Bookapi.Books.GetBooks
{

   

    public class GetBooksQuery : IRequest<IEnumerable<Book>>
    {
       
    }
    public class GetBooksHandler : IRequestHandler<GetBooksQuery, IEnumerable<Book>>
    {
        readonly ProductContext _context;

        public GetBooksHandler(ProductContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Book>> Handle(GetBooksQuery request, CancellationToken cancellationToken)
        {
            var allBooks = await _context.Books.ToListAsync(cancellationToken);

            var result = allBooks.Adapt<IEnumerable<Book>>();
            return result;
        }
    }
}
