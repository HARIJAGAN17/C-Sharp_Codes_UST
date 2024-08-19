using Bookapi.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Bookapi.Books.DeleteBook
{

    public class DeleteBookCommand : IRequest<DeleteBookResponse>
    {
        public int Id { get; set; }
    }
    public class DeleteBookResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
        public class DeleteBookHandler : IRequestHandler<DeleteBookCommand, DeleteBookResponse>
        {
            readonly ProductContext _context;

            public DeleteBookHandler(ProductContext context)
            {
                _context = context;
            }
            public async Task<DeleteBookResponse> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
            {
                var isBookExist = await _context.Books.FirstOrDefaultAsync(x=>x.Id == request.Id);
                if (isBookExist != null)
                {
                    _context.Books.Remove(isBookExist);
                    await _context.SaveChangesAsync(cancellationToken);
                    return new DeleteBookResponse { Success = true,Message="Book was deleted successfully" };
                }
                return new DeleteBookResponse { Success = false, Message = "Book doesn't exist" };
            } 
        }
    }
