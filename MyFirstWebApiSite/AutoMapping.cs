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
            CreateMap<Contact, ContactDTO>().ReverseMap();
            CreateMap<Donor, DonorDTO>().ForMember(d => d.Contact, opts => opts.MapFrom(src => src.Contact.ContactType)).ReverseMap();
          CreateMap<DonorsVisit, DonorsVisitDTO>()
                .ForMember(d => d.FirstName, opts => opts.MapFrom(src => src.Donor.FirstName))
                .ForMember(d => d.LastName, opts => opts.MapFrom(src => src.Donor.LastName))
                .ForMember(d => d.address, opts => opts.MapFrom(src => src.Donor.Street+" "+ src.Donor.HouseNum))
                .ForMember(d => d.City, opts => opts.MapFrom(src => src.Donor.City))
                .ForMember(d => d.Contact, opts => opts.MapFrom(src => src.Donor.Contact.ContactType))
                .ForMember(d => d.Degree, opts => opts.MapFrom(src => src.Donor.Degree))
                .ForMember(d => d.Group, opts => opts.MapFrom(src => src.GroupId))
                .ForMember(d => d.PreferredTime, opts => opts.MapFrom(src => src.PreferredTime.Time1))
                .ForMember(d => d.Status, opts => opts.MapFrom(src => src.Status.Status1))
                .ForMember(d => d.happen, opts => opts.MapFrom(src => src.Status.Happen))
                .ReverseMap();
          
         // CreateMap<Group, GroupDTO>().ForMember(gDTO=>gDTO.TeamHead,opts=>opts.MapFrom(src=>src.TeamHead.FirstName+" "+src.TeamHead.LastName)).ReverseMap();
            CreateMap<Group, GroupDTO>().ReverseMap();
            CreateMap<Massage, MassageDTO>().ForMember(m => m.Group, opts => opts.MapFrom(src => src.Group.GroupNum)).ReverseMap();
            CreateMap<Raise, RaiseDTO>().ReverseMap(); ;
            CreateMap<RaisesInGroup, RaisesInGroupDTO>().ReverseMap();
            CreateMap<RisingVisit, RisingVisitDTO>().ReverseMap();
            CreateMap<Status, StatusDTO>().ReverseMap();
            CreateMap<Time, TimeDTO>().ReverseMap();
        }


    }
}
