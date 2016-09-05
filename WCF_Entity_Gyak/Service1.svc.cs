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
        private ContractFunctions _contractFunctions;
        private LandFunctions _landFunctions;
        private GrainFunctions _grainFunctions;
        public Service1()
        {
            //_db = new DataBaseContext();
            _userFunction = new UserFunctions();
            _contractFunctions = new ContractFunctions();
            _landFunctions = new LandFunctions();
            _grainFunctions = new GrainFunctions();
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
                return UserFunctions.GetUserById(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [OperationContract]
        public bool AddContract(int userId,string startDate)
        {
            DateTime sDate;
            DateTime.TryParseExact(startDate, "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out sDate);
            try
            {
                _contractFunctions.AddContract(userId, DateTime.Now, sDate);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return true;
        }
    }
}
