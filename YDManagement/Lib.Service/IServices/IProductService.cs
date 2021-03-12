﻿using System;
using Lib.Data.Entity;
using Lib.Service.Dtos;
using System.Collections.Generic;

namespace Lib.Service.IServices
{
    public interface IProductService : IReadOnlyService<ProductDto>
    {
        Product Create(Product obj);
        void Update(Product obj);
        void Delete(int id);
        void DeleteMany(List<int> ids);
        int GetRecordCount();
        bool IsOutOfStock(int? id = 0, int? quantity = 0);
    }
}
