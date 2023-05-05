using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task05._04._23.Services.Implementations.Book.BookService;
using Task05._04._23.Services.Implementations.Base;

namespace Task05._04._23.Services.Implementations.Book
{
   
        internal class BookService : BaseService<Models.Book>, IBookService
        {

        }
    
}
