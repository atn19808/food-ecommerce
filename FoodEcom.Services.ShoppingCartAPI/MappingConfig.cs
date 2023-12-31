﻿using AutoMapper;
using FoodEcom.Services.ShoppingCartAPI.Models;
using FoodEcom.Services.ShoppingCartAPI.Models.Dto;

namespace FoodEcom.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
				config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
			});
            return mappingConfig;
        }
    }
}
