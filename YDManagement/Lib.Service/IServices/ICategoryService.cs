﻿using Lib.Data.Entity;
using Lib.Service.Dtos;
using System.Collections.Generic;

namespace Lib.Service.IServices
{
    public interface ICategoryService : IReadOnlyService<CategoryDto>
    {
        Category Create(Category obj);
        void Update(Category obj);
        void Delete(int id);
        void DeleteMany(List<int> ids);
        int GetRecordCount();
        void Delete(CategoryDto data);
    }
}
