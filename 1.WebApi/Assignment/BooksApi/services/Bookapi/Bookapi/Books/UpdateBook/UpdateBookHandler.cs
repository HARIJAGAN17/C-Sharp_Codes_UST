using Bookapi.Data;
using Bookapi.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Bookapi.Books.UpdateBook
{

    public class UpdateBookCommand:IRequest<UpdateBookResponse>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public double Price { get; set; }
    }

    public class UpdateBookResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
        public class UpdateBookHandler : IRequestHandler<UpdateBookCommand, UpdateBookResponse>
        {
            readonly ProductContext _context;

            public UpdateBookHandler(ProductContext context)
            {
                _context = context;
            }
            public async Task<UpdateBookResponse> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
            {
                var isBookExist = await _context.Books.FirstOrDefaultAsync(x => x.Id == request.Id);

                if (isBookExist != null)
                {

                    isBookExist.Title = request.Title;
                    isBookExist.Author = request.Author;
                    isBookExist.Price = request.Price;
                    await _context.SaveChangesAsync(cancellationToken);
                    return new UpdateBookResponse { Success = true, Message = "Book was updated successfully" };
                }
                return new UpdateBookResponse { Success = false, Message = "Book doesn't exist" };
            }
        }
    }

