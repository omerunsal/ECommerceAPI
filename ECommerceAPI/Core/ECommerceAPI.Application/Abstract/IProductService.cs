﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceAPI.Domain.Entities;

namespace ECommerceAPI.Application.Abstract
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}