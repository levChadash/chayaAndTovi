using AutoMapper;
using DL;
using DTO;
using Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class GroupBL : IGroupBL
    {
        IGroupDL gdl;
        IMapper mapper;
        IConfiguration _configuration;
        public GroupBL(IGroupDL gdl,IMapper mapper, IConfiguration configuration)
        {
            this.gdl = gdl;
            this.mapper = mapper;
            _configuration = configuration;
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

        public async Task<GroupDTO> GetGroupByPassword(string pass,string name)
        {
            Group g = await gdl.GetGroupByPassword(pass);
            if (g == null)
                return null;
            string n = g.TeamHead.FirstName + " " + g.TeamHead.LastName;
            if (n != name)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration.GetSection("key").Value);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, g.TeamHead.FirstName.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            g.Token = tokenHandler.WriteToken(token);
            return WithoutPassword(g);
          
           
        }
        public  GroupDTO WithoutPassword(Group user)
        {
            user.Password = null;
            GroupDTO gDTO = mapper.Map<Group, GroupDTO>(user);
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
            List<Raise> lr = await gdl.GetListOfRaisesInGroup(id);
            List<RaiseDTO> lrDTO = mapper.Map<List<Raise>, List<RaiseDTO>>(lr);
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

