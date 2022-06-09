using Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DL
{
    public class DonorDL : IDonorDL
    {
        
        DonationManagementContext dmc;
        public DonorDL(DonationManagementContext dmc)
        {
            this.dmc = dmc;
        }
        public async Task<List<Donor>> GetDonors()
        {
            List<Donor> ld = await dmc.Donors.Include(d=>d.Contact).ToListAsync();
            return ld;
        }

        public async Task<List<Donor>> GetDonor(string fn, string ln)
        {
            List<Donor> ld = await dmc.Donors.Where(d => d.FirstName == fn && d.LastName == ln).Include(d => d.Contact).ToListAsync();
            return ld;
        }
        public  async Task<string> getNameOfContact(int? contactId)
        {
            if (contactId != null)
            {
                var name = await dmc.Contacts.Where(c => c.Id == contactId).FirstAsync();
                string s = name.ContactType;
                return s;
            }
            else return "לא מוגדר";
        }
        public async Task<int> getIdOfContact(string contactName)
        {
            if (contactName != null)
            {
                var name = await dmc.Contacts.Where(c => c.ContactType == contactName).FirstAsync();
                int s = name.Id;
                return s;
            }
            else return 16;
        }


        public async Task<Donor> GetDonorById(int id)
        {
            Donor d = await dmc.Donors.FindAsync(id);
            return d;
        }

        public async Task<List<Contact>> GetContacts()
        {
            return await dmc.Contacts.ToListAsync();
        }
        public async Task<bool> PostDonor(Donor d)
        {
            await dmc.Donors.AddAsync(d);
            await dmc.SaveChangesAsync();
            return true;
        }
        public async Task<bool> PutDonor(int id, Donor d)
        {
            var d2 = await dmc.Donors.FindAsync(id);
            if (d2 == null)
                return false;
            dmc.Entry(d2).CurrentValues.SetValues(d);
            await dmc.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteDonor(int id)
        {
            var donor = await GetDonorById(id);
            if (donor == null)
                return false;
            dmc.Donors.Remove(donor);
            await dmc.SaveChangesAsync();
            return true;
        }
    }
}
