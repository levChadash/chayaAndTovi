using AutoMapper;
using Entity;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class AutoMapping: Profile
    {
        public AutoMapping()
        {
            CreateMap<Contact, ContactDTO>();
            CreateMap<Donor, DonorDTO>();
            CreateMap<DonorsVisit, DonorsVisitDTO>();
            CreateMap<Group, GroupDTO>();
            CreateMap<Massage, MassageDTO>();
            CreateMap<RaiseDTO, RaiseDTO>();
            CreateMap<RaisesInGroup, RaisesInGroupDTO>();
            CreateMap<RisingVisit, RisingVisitDTO>();
            CreateMap<Status, StatusDTO>();
            CreateMap<Time, TimeDTO>();
        }
    }
}
