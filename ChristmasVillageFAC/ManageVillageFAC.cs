using ChristmasVillageBO;
using ChristmasVillageIFAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageFAC
{
    public class ManageVillageFAC : ManageVillageIFAC
    {
        public void createManageVillage(ManageVillageBO village)
        {
            try
            {
                ManageVillageBL.Insert(village);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public ManageVillageBO findVillageByUser(int id_User)
        {
            try
            {
                return ManageVillageBL.SearchVillage(id_User);
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}
