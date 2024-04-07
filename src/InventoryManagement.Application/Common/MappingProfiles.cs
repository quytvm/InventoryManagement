﻿using AutoMapper;
using ExampleProject.Core.Entities;
using InventoryManagement.Application.Dto;
using InventoryManagement.Application.Dto.Categories;
using InventoryManagement.Application.Dto.Customers;
using InventoryManagement.Application.Dto.Products;
using InventoryManagement.Application.Dto.ProductionOrderDetails;
using InventoryManagement.Application.Dto.ProductOrders;
using InventoryManagement.Application.Dto.SaleOrderDetails;
using InventoryManagement.Application.Dto.SaleOrders;
using InventoryManagement.Application.Dto.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Application.Common
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Supplier,SupplierDto>().ReverseMap();
            CreateMap<Supplier, CreateSupplierDto>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Customer, CreateCustomerDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<ProductionOrderDetail, CreateProductionOrderDetailDto>().ReverseMap();
            CreateMap<ProductionOrderDetail, ProductionOrderDetailDto>().ReverseMap();
            CreateMap<ProductionOrder, ProductionOrderDto>().ReverseMap();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>().ForMember(dest => dest.Image, opt => opt.Ignore());
            CreateMap<Product, CreateProductDto>().ForMember(dest => dest.Image, opt => opt.Ignore()).ReverseMap();
            //CreateMap<Product, UpdateProductDto>().ForMember(dest => dest.Image, opt => opt.Ignore()).ReverseMap();
            CreateMap<SaleOrder, SaleOrderDto>().ReverseMap();
            CreateMap<SaleOrderDetail, SaleOrderDetailDto>().ReverseMap();
            CreateMap<SaleOrderDetail, CreateSaleOrderDetailDto>().ReverseMap();
            CreateMap<Stock, StockDto>().ReverseMap();
        }
    }
}