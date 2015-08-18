using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageBO
{
    /*
     * Classe User, déclarations variables avec getter et setter et constructeurs
     */

    [DataContract(Namespace = "urn:ChristmasVillageBO.UserBO")]
    public class UserBO
    {
        private int _id_user;
        private string _username;
        private string _password;
        private string _email;
        private int _capital;
        private string _status;

        public UserBO() {}

        public UserBO(int UserId, string UserName, string UserPassword, string UserEmail, int UserCapital, string UserStatus)
            : this()
        {
            _id_user = UserId;
            _username = UserName;
            _password = UserPassword;
            _email = UserEmail;
            _capital = UserCapital;
            _status = UserStatus;
        }

        [DataMember(Name = "id_user")]
        public int id_user
        {
            get { return _id_user; }
            set { _id_user = value; }
        }

        [DataMember(Name = "username")]
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        [DataMember(Name = "password")]
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        [DataMember(Name = "email")]
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        [DataMember(Name = "capital")]
        public int capital
        {
            get { return _capital; }
            set { _capital = value; }
        }

        [DataMember(Name = "status")]
        public string status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
