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
            CreateMap<Donor, DonorDTO>().ReverseMap();
            CreateMap<DonorsVisit, DonorsVisitDTO>()
                .ForMember(d => d.name, opts => opts.MapFrom(src => src.Donor.FirstName + " " + src.Donor.LastName))
                .ForMember(d => d.address, opts => opts.MapFrom(src => src.Donor.Street + " " + src.Donor.HouseNum+", "+src.Donor.City))
                .ForMember(d => d.Contact, opts => opts.MapFrom(src => src.Donor.Contact.ContactType))
                .ForMember(d => d.Degree, opts => opts.MapFrom(src => src.Donor.Degree))
                .ForMember(d => d.PreferredTime, opts => opts.MapFrom(src => src.PreferredTime.Time1))
                .ForMember(d => d.Status, opts => opts.MapFrom(src => src.Status.Status1)).ReverseMap();
         // CreateMap<Group, GroupDTO>().ForMember(gDTO=>gDTO.TeamHead,opts=>opts.MapFrom(src=>src.TeamHead.FirstName+" "+src.TeamHead.LastName)).ReverseMap();
            CreateMap<Group, GroupDTO>().ReverseMap();
            CreateMap<Massage, MassageDTO>().ReverseMap();
            CreateMap<Raise, RaiseDTO>().ReverseMap(); ;
            CreateMap<RaisesInGroup, RaisesInGroupDTO>().ReverseMap();
            CreateMap<RisingVisit, RisingVisitDTO>().ReverseMap();
            CreateMap<Status, StatusDTO>().ReverseMap();
            CreateMap<Time, TimeDTO>().ReverseMap();
        }


    }
}
