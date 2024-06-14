using AutoMapper;
using Forum.Entities;
using Forum.Models;
using Forum.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Forum.Models.CommentForUpdatingDto;

namespace Forum.Service
{
    public static class MappingInitializer
    {
        public static IMapper Initialize()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Topic, TopicDto>()
                   .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.Comments));
                cfg.CreateMap<Comment, CommentDto>();
                cfg.CreateMap<TopicForCreatingDto, Topic>();
                cfg.CreateMap<TopicForUpdatingDto, Topic>();
                cfg.CreateMap<CommentForCreatingDto, Comment>();
                cfg.CreateMap<CommentForUpdatingDto, Comment>();

                cfg.CreateMap<UserDto, User>().ReverseMap();
                cfg.CreateMap<RegistrationRequestDto, User>()
                .ForMember(destination => destination.UserName, options => options.MapFrom(source => source.Email))
                .ForMember(destination => destination.NormalizedUserName, options => options.MapFrom(source => source.Email.ToUpper()))
                .ForMember(destination => destination.Email, options => options.MapFrom(source => source.Email))
                .ForMember(destination => destination.NormalizedEmail, options => options.MapFrom(source => source.Email.ToUpper()));
               
            });

            return config.CreateMapper();
        }

    }
}



