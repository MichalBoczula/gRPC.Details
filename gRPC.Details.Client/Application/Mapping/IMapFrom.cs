﻿using AutoMapper;

namespace gRPC.Details.Client.Application.Mapping
{
    internal interface IMapFrom<T>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
