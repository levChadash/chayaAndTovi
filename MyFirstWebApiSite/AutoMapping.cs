using AutoMapper;
using Entity;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWebApiSite
{
  public class AutoMapping: Profile
    {
        public AutoMapping()
        {
            CreateMap<Contact, ContactDTO>();
            CreateMap<Donor, DonorDTO>();
            CreateMap<DonorsVisit, DonorsVisitDTO>();
         // CreateMap<Group, GroupDTO>().ForMember(gDTO=>gDTO.TeamHead,opts=>opts.MapFrom(src=>src.TeamHead.FirstName+" "+src.TeamHead.LastName)).ReverseMap();
            CreateMap<Group, GroupDTO>().ReverseMap();
            CreateMap<Massage, MassageDTO>();
            CreateMap<Raise, RaiseDTO>().ReverseMap(); ;
            CreateMap<RaisesInGroup, RaisesInGroupDTO>();
            CreateMap<RisingVisit, RisingVisitDTO>();
            CreateMap<Status, StatusDTO>();
            CreateMap<Time, TimeDTO>();
        }


    }
}
