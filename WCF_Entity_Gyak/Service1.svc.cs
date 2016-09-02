using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCF_Entity_Gyak.Model;
using System.Net;
using System.ServiceModel.Activation;
using WCF_Entity_Gyak.DAL;

namespace WCF_Entity_Gyak
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

    [ServiceContract]
    public class Service1 
    {
        //private DataBaseContext _db;
        private UserFunctions _userFunction;
        public Service1()
        {
            //_db = new DataBaseContext();
            _userFunction = new UserFunctions();
            
        }

        [OperationContract]
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        [OperationContract]
        public bool AddUser(string firstName,string lastName, string idCardNumber)
        {
            bool isSuccess;
            try
            {
                isSuccess = _userFunction.AddUser(firstName, lastName, idCardNumber);
            }
            catch (Exception ex)
            {
                //TODO: normal exception handling
                throw ex;
            }
            return isSuccess;
        }

        [OperationContract]
        public List<User> GetUsers()
        {
            List<User> users;
            try
            {
                users = _userFunction.GetUsers();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return users;
        }

        [OperationContract]
        public User GetUserById(int id)
        {
            try
            {
                return _userFunction.GetUserById(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
