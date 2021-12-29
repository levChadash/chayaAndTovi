using AutoMapper;
using DL;
using DTO;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class GroupBL : IGroupBL
    {
        IGroupDL gdl;
        IMapper mapper;
        public GroupBL(IGroupDL gdl,IMapper mapper)
        {
            this.gdl = gdl;
            this.mapper = mapper;
        }

        public async Task<GroupDTO> GetGroupByIdOfHead(int id)
        {
            Group g = await gdl.GetGroupByIdOfHead(id);
            GroupDTO gDTO = mapper.Map<Group, GroupDTO>(g);

            return gDTO;
        }

        public async Task<GroupDTO> GetGroupById(int id)
        {
            Group g = await gdl.GetGroupById(id);
            GroupDTO gDTO = mapper.Map<Group, GroupDTO>(g);

            return gDTO;
        }

        public async Task<GroupDTO> GetGroupByNum(int num)
        {
            Group g = await gdl.GetGroupByNum(num);
            GroupDTO gDTO = mapper.Map<Group, GroupDTO>(g);

            return gDTO;
        }
        public async Task<List<RaiseDTO>> GetListOfRaisesInGroup(int id)
        {
            List<RaiseDTO> lr = await gdl.GetListOfRaisesInGroup(id);
            List<RaiseDTO> lrDTO = mapper.Map<List<RaiseDTO>, List<RaiseDTO>>(lr);
            return lrDTO;
        }

        public async Task<List<GroupDTO>> GetGroups()
        {
            List<Group> lg = await gdl.GetGroups();
            List<GroupDTO> lgDTO = mapper.Map<List<Group>, List<GroupDTO>>(lg);

            return lgDTO;
        }
        public async Task<bool> PostGroup(GroupDTO g)
        {
            Group gg = mapper.Map<GroupDTO, Group>(g);
            return await gdl.PostGroup(gg);
        }
        public async Task<bool> PutGroup(int id, GroupDTO g)
        {
            Group gg = mapper.Map<GroupDTO, Group>(g);
            return await gdl.PutGroup(id, gg);

        }

        public async Task<bool> DeleteGroup(int IdOfHead)
        {
            return await gdl.DeleteGroup(IdOfHead);
        }
    }
}

