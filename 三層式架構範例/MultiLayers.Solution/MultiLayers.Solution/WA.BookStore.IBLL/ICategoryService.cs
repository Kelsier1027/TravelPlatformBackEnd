using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WA.BookStore.DTO;

namespace WA.BookStore.IBLL
{
    public interface ICategoryService
    {
        void Create(CategoryDto dto);
        void Update(CategoryDto dto);
        List<CategoryIndexDto> Search(string name);
    }
}
