using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Response;
using FireSharp.Config;
using FireSharp.Interfaces;
using System.Windows.Forms;

namespace AnyMessAppWin.Backend_Services
{
    public class LoginChecker { 

            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "VV2PEctRnqHQ1KVcDEBlprQiD4wzSS4wYUG4FUY2", // Secret Key  
                BasePath = "https://anymesswin-app-default-rtdb.asia-southeast1.firebasedatabase.app/" // Basekey 
            };

        IFirebaseClient client; 
       
        public static bool PasswordConfirmChecker(string password, string confirmpassword)
        {
            return (password == confirmpassword); 
        }

        public async void GetNameAndCompareHk(string id, string name, string middlename, string lastname)
        {
            client = new FireSharp.FirebaseClient(config);

            FirebaseResponse responseName = await client.GetTaskAsync("Houkeeper Information/"+ id);
            var resultName = responseName.ResultAs<DataHousekeeper>();

            string[] names = new string[] { name, middlename, lastname };
            string[] nameFromDB = new string[] { resultName.HousekeeperName, resultName.HouserkeeperMiddleName, resultName.HousekeeperLastName };

            if(CheckNameExist(names, nameFromDB))
            {
                MessageBox.Show("Name already exist, Please Try Again!"); 
            } 
        }   

        public async void GetNameAndCompareEmployer(string id, string name, string middlename, string lastname)
        {
            client = new FireSharp.FirebaseClient(config);

            FirebaseResponse responseEmployer = await client.GetTaskAsync("Houkeeper Information/" + id);
            var resultNameEmployer = responseEmployer.ResultAs<DataEmployer>();

            string[] names = new string[] { name, middlename, lastname };
            string[] nameFromDB = new string[] { resultNameEmployer.EmployerName, resultNameEmployer.EmployerMiddleName, resultNameEmployer.EmployerLastName };

            if(CheckNameExist(names, nameFromDB))
            {
                MessageBox.Show("Name already exist, please try again!");
            }
        }

        public static bool CheckNameExist(string[] names, string[] namesFromDB)
        {
            int indicator = 0; 
            for(int i = 0; i < names.Length; i++)
            {
                if (names[i] == namesFromDB[i]) { indicator++;  }
            }

            return (indicator == 3); 
        }

        public async void LoginCheck(string username, string password)
        {
            client = new FireSharp.FirebaseClient(config);

            try
            {
                FirebaseResponse responseDB = await client.GetTaskAsync("Login Accounts/" + username);
                DataCreateAccount resultAccount = responseDB.ResultAs<DataCreateAccount>();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }
    }
}
