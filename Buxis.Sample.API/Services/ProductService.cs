﻿using Buxis.Sample.ApplicationCore.DTOs;
using Buxis.Sample.ApplicationCore.Entities;
using Buxis.Sample.ApplicationCore.Interfaces;
using Buxis.Sample.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Buxis.Sample.API.Services
{
    public class ProductService : IProductService
    {
        private readonly BuxiDbContext buxiDbContext;

        public ProductService(BuxiDbContext buxiDbContext)
        {
            this.buxiDbContext = buxiDbContext;
        }

        public async Task<ProductDto> CreateAsync(CreateProductDto model)
        {
            var product = new Product
            {
                Nombre = model.Nombre
            };

            buxiDbContext.Product.Add(product);

            await buxiDbContext.SaveChangesAsync();

            var dto = new ProductDto
            {
                Id = product.Id,
                Nombre = product.Nombre
            };
            return dto;
        }

        public async Task<ProductDto[]> GetAllAsync()
        {
            //var products = from p in buxiDbContext.Product
            //               select new ProductDto
            //               {
            //                   Id = p.Id,
            //                   Nombre =p.Nombre
            //               };

            var products = await buxiDbContext
                .Product
                .Select(p => new ProductDto
                {
                    Id = p.Id,
                    Nombre = p.Nombre
                })
                .ToArrayAsync();

            return products;
        }
    }
}