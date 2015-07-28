using ChristmasVillageFAC;
using ChristmasVillageIFAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageHosting
{
    public class Hosting
    {
        internal static ServiceHost ServiceFactory = null;
        internal static ServiceHost ServiceManageFactory = null;
        internal static ServiceHost ServiceManageVillage = null;
        internal static ServiceHost ServiceUser = null;
        internal static ServiceHost ServiceVillage = null;

        public void StartServer()
        {
            ServiceFactory = new ServiceHost(typeof(FactoryFAC));
            ServiceFactory.Open();
            Console.WriteLine("Service : Factory Started ");

            ServiceManageFactory = new ServiceHost(typeof(ManageVillageFAC));
            ServiceManageFactory.Open();
            Console.WriteLine("Service : Manage Started ");

            ServiceManageVillage = new ServiceHost(typeof(ManageFactoryFAC));
            ServiceManageVillage.Open();
            Console.WriteLine("Service : Own Started ");
            
            ServiceUser = new ServiceHost(typeof(UserFAC));
            ServiceUser.Open();
            Console.WriteLine("Service : User Started ");

            ServiceVillage = new ServiceHost(typeof(VillageFAC));
            ServiceVillage.Open();
            Console.WriteLine("Service : Village Started ");
        }

        public void StopServer()
        {
            if (ServiceFactory != null && ServiceFactory.State != CommunicationState.Closed)
                ServiceFactory.Close();
            else if (ServiceManageFactory != null && ServiceManageFactory.State != CommunicationState.Closed)
                ServiceManageFactory.Close();
            else if (ServiceManageVillage != null && ServiceManageVillage.State != CommunicationState.Closed)
                ServiceManageVillage.Close();
            else if (ServiceUser != null && ServiceUser.State != CommunicationState.Closed)
                ServiceUser.Close();
            else if (ServiceVillage != null && ServiceVillage.State != CommunicationState.Closed)
                ServiceVillage.Close();
        }
    }
}
