using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.Business.Features.Card.CreateCard;
using Trello.Business.Features.Card.UpdateCard;
using Trollo.Entities;

namespace Trello.Business.Mapper
{
    public sealed class Mapping : Profile
    {
        public Mapping()
        {
                CreateMap<CreateCartCommand,Cart>().ReverseMap();
            CreateMap<UpdateCardCommand,Cart>().ReverseMap();
           
          
        }
    }
}
