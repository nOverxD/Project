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
        internal static ServiceHost ServiceManage = null;
        internal static ServiceHost ServiceOwn = null;
        internal static ServiceHost ServiceUser = null;
        internal static ServiceHost ServiceVillage = null;

        public void StartServer()
        {
            ServiceFactory = new ServiceHost(typeof(FactoryFAC));
            ServiceFactory.Open();
            Console.WriteLine("Service : Factory Started ");

            /*
            ServiceManage = new ServiceHost(typeof(ManageVillageFAC));
            ServiceManage.Open();
            Console.WriteLine("Service : Manage Started ");

            ServiceOwn = new ServiceHost(typeof(ManageFactoryFAC));
            ServiceOwn.Open();
            Console.WriteLine("Service : Own Started ");
            */
            
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
            else if (ServiceManage != null && ServiceManage.State != CommunicationState.Closed)
                ServiceManage.Close();
            else if (ServiceOwn != null && ServiceOwn.State != CommunicationState.Closed)
                ServiceOwn.Close();
            else if (ServiceUser != null && ServiceUser.State != CommunicationState.Closed)
                ServiceUser.Close();
            else if (ServiceVillage != null && ServiceVillage.State != CommunicationState.Closed)
                ServiceVillage.Close();
        }
    }
}
