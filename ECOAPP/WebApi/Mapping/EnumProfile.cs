using System;
using AutoMapper;
using ECOAPP.Core.Common.Enums;
using ECOAPP.Core.Dto;

namespace ECOAPP.WebApi.Mapping
{
    /// <summary>
    /// Enum mapping
    /// </summary>
    public class EnumProfile : Profile
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public EnumProfile()
        {
            CreateMap<Enum, EnumDto>().ConvertUsing(src => new EnumDto { Code = src.ToString(), Description = src.GetDescription() });
        }
    }
}