using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Response;
using FireSharp.Config;
using FireSharp.Interfaces;
using System.Windows.Forms;
using System.Data;

namespace AnyMessAppWin.Backend_Services
{
    public class DatabaseConfiguration
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "VV2PEctRnqHQ1KVcDEBlprQiD4wzSS4wYUG4FUY2", // Secret Key  
            BasePath = "https://anymesswin-app-default-rtdb.asia-southeast1.firebasedatabase.app/" // Basekey 
        };

        IFirebaseClient client;

        private static string typeOfUser;
        // Agency
        public async void SaveDataAgency(string name, string address, string contact, string website, string agencyCode)
        {
            client = new FireSharp.FirebaseClient(config);

            typeOfUser = "Agency";

            if (name != null && address != null && address != null && contact != null && website != null && agencyCode != null)
            {
                // Agency Data 
                Data agencyData = new Data
                {
                    AgencyName = name,
                    AgencyAddress = address,
                    AgencyContactNumber = contact,
                    AgencyWebsite = website,
                    AgencyCode = agencyCode
                };

                try
                {
                    // Fetch Data again 
                    SetResponse responseData = await client.SetTaskAsync("Agency Information/" + name, agencyData);
                    Data resultAgencyID = responseData.ResultAs<Data>();

                    MessageBox.Show("Data have been saved! Now proceed to create account");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid Data!");
            }
        }

        // Housekeeper
        public async void SavaDataHousekeeper(string firstName, string middlename, string lastname, string address, string age, string sex, string contactnumber, string skill)
        {
            client = new FireSharp.FirebaseClient(config);

            typeOfUser = "Housekeeper";

            if (firstName != null && middlename != null && lastname != null && address != null && age != null && sex != null && contactnumber != null && skill != null)
            {
                // PrepareData
                DataHousekeeper dataHousekeeper = new DataHousekeeper
                {
                    HousekeeperName = firstName,
                    HousekeeperLastName = lastname,
                    HouserkeeperMiddleName = middlename,
                    HousekeeperAge = age,
                    HousekeeperContact = contactnumber,
                    HousekeeperAddress = address,
                    HousekeeperSex = sex,
                    HousekeeperSkill = skill,
                    TypeOfUser = typeOfUser
                };

                try
                {
                    SetResponse response = await client.SetTaskAsync("Housekeeper Information/" + firstName, dataHousekeeper);
                    DataHousekeeper resultHkID = response.ResultAs<DataHousekeeper>();

                    MessageBox.Show("Data have been saved! Now proceed to create account");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
        }

        // Employer
        public async void SavaDataEmployer(string firstname, string middlename, string lastname, string address, string contactnumber, string age, string sex)
        {
            client = new FireSharp.FirebaseClient(config);

            typeOfUser = "Employer";

            if (firstname != null && middlename != null && lastname != null && address != null && age != null && sex != null && contactnumber != null)
            {
                DataEmployer dataEmployer = new DataEmployer
                {
                    EmployerName = firstname,
                    EmployerMiddleName = middlename,
                    EmployerLastName = lastname,
                    EmployerAddress = address,
                    EmployerAge = age,
                    EmployerContactNumber = contactnumber,
                    EmployerSex = sex,
                    TypeOfUser = typeOfUser
                };

                try
                {
                    SetResponse response = await client.SetTaskAsync("Employer Information/" + firstname, dataEmployer);
                    DataEmployer resultEmployerID = response.ResultAs<DataEmployer>();
                    MessageBox.Show("Data have been saved! Now proceed to create account");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Login Account Save 
        public async void SavaDataCreateAccount(string username, string firstname, string email, string password, string confirmpass)
        {
            client = new FireSharp.FirebaseClient(config);

            if (SignUpAgency.AgencyClicked) { typeOfUser = "Agency"; }
            if (SignUpEmployer.EmployerClicked) { typeOfUser = "Employer"; }
            if (SignUpHousekeeping.HousekeepingClicked) { typeOfUser = "Housekeeping"; }

            if (username != null && firstname != null && email != null && password != null && confirmpass != null)
            {
                // Send Create Data to Firebase
                DataCreateAccount createData = new DataCreateAccount
                {
                    TypeOfUser = typeOfUser,
                    Username = username,
                    FirstName = firstname,
                    Email = email,
                    Password = password,
                    ConfirmPassWord = confirmpass
                };

                try
                {
                    SetResponse response = await client.SetTaskAsync("Login Accounts/" + username, createData);
                    DataCreateAccount resultCreateID = response.ResultAs<DataCreateAccount>();

                    MessageBox.Show("Account Successfully Created!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Edit Profile to Database (Agency)
        public async void SavaEditProfileAgency(string agencyName, string imageAgencyData, string aboutUs, string addressData, string websiteData, string agencyContact, string agencyLookingfor)
        {
            client = new FireSharp.FirebaseClient(config);

            if (agencyName != null && imageAgencyData != null && aboutUs != null && addressData != null && websiteData != null)
            {
                var agencyEditProfileData = new DataModels.EditProfileAgencyModel
                {
                    AgencyName = agencyName,
                    AboutUs = aboutUs,
                    AddressData = addressData,
                    ImageAgencyData = imageAgencyData,
                    WebsiteData = websiteData,
                    AgencyContact = agencyContact,
                    AgencyLookingFor = agencyLookingfor
                };

                try
                {
                    SetResponse responseSet = await client.SetTaskAsync("Edit Profile Agency/" + agencyName, agencyEditProfileData);

                    MessageBox.Show("Saved Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Edit Profile to Database (Employer)
        public async void SaveEditProfileEmployer(string employerName, string imageAgencyData, string aboutMe, string addressData, string emailData, string contactNumber, string lookingFor)
        {
            client = new FireSharp.FirebaseClient(config);
            if (employerName != null && imageAgencyData != null && aboutMe != null && addressData != null && emailData != null)
            {
                var employerEditProfileData = new DataModels.EditProfileEmployerModel
                {
                    FirstName = employerName,
                    ImageEmployerData = imageAgencyData,
                    employerAboutMe = aboutMe,
                    employerAddress = addressData,
                    employerEmail = emailData,
                    employerContact = contactNumber,
                    employerLookingFor = lookingFor
                };

                try
                {
                    SetResponse responseSetEmployer = await client.SetTaskAsync("Edit Profile Employer/" + employerName, employerEditProfileData);

                    MessageBox.Show("Saved Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Invalid Data!");
            }
        }

        // Edit Profile to DB (Housekeeper)
        public async void SaveEditProfileHousekeeper(string firstName, string rateHk, string imageHkData, string aboutMeHk, string addressHk, string contactNumber, string emailHk, string skill)
        {
            client = new FireSharp.FirebaseClient(config);

            if (firstName != null && rateHk != null && imageHkData != null && aboutMeHk != null && addressHk != null && contactNumber != null && emailHk != null && skill != null)
            {
                var housekeeperEditProfileData = new DataModels.EditProfileHkModel
                {
                    FirstName = firstName,
                    RateHk = rateHk,
                    ImageHkData = imageHkData,
                    AboutMeHk = aboutMeHk,
                    AddressHk = addressHk,
                    ContactNumberHk = contactNumber,
                    EmailHk = emailHk,
                    OtherSkills = skill
                };

                try
                {
                    SetResponse responseHkSet = await client.SetTaskAsync("Edit Profile Housekeeper/" + firstName, housekeeperEditProfileData);

                    MessageBox.Show("Saved Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Invalid Input!");
            }
        }

        // Agency
        FirebaseResponse response;
        static Data dataAgencyResult;
        public async void fetchAgencyDataDB(string name)
        {
            client = new FireSharp.FirebaseClient(config);

            if (name != null)
            {
                try
                {
                    response = await client.GetTaskAsync("Agency Information/" + name);
                    dataAgencyResult = response.ResultAs<Data>();
                }
                catch (Exception)
                {
                    MessageBox.Show($"{name} does not found!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Name");
            }

        }

        public static Data GetDataProfileAgency()
        {
            return dataAgencyResult;
        }

        // Employer
        static DataEmployer dataEmployerResult;
        public async void fetchEmployerDataDB(string name)
        {
            client = new FireSharp.FirebaseClient(config);

            if (name != null)
            {
                try
                {
                    response = await client.GetTaskAsync("Employer Information/" + name);
                    dataEmployerResult = response.ResultAs<DataEmployer>();
                }
                catch (Exception)
                {
                    MessageBox.Show($"{name} does not found!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Name");
            }
        }

        public static DataEmployer GetDataProfileEmployer()
        {
            return dataEmployerResult;
        }



        // Housekeeping 
        static DataHousekeeper dataHousekeeperResult;
        public async void fetchHousekeepingAccount(string name)
        {
            client = new FireSharp.FirebaseClient(config);

            if (name != null)
            {
                try
                {
                    response = await client.GetTaskAsync("Housekeeper Information/" + name);
                    dataHousekeeperResult = response.ResultAs<DataHousekeeper>();
                }
                catch (Exception)
                {
                    MessageBox.Show($"{name} does not found!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Name!");
            }
        }

        public static DataHousekeeper GetDataProfileHk()
        {
            return dataHousekeeperResult;
        }

        // Create Account
        static DataCreateAccount createAccountResult;
        public async void fetchCreateAccountData(string username)
        {
            client = new FireSharp.FirebaseClient(config);

            if (username != null)
            {
                try
                {
                    response = await client.GetTaskAsync("Login Accounts/" + username);
                    createAccountResult = response.ResultAs<DataCreateAccount>();
                }
                catch (Exception)
                {
                    MessageBox.Show($"{username} does not found!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Name");
            }
        }

        public static DataCreateAccount GetDataCreateAccount()
        {
            return createAccountResult;
        }


        // Retrieve Edit Profile Data
        static DataModels.EditProfileAgencyModel dataEditResultAgency;
        public async void RetrieveAgencyEditData(string firstname)
        {
            client = new FireSharp.FirebaseClient(config);

            if (firstname != null)
            {
                try
                {
                    response = await client.GetTaskAsync("Edit Profile Agency/" + firstname);
                    dataEditResultAgency = response.ResultAs<DataModels.EditProfileAgencyModel>();
                }
                catch (Exception)
                {
                    MessageBox.Show("Name does not exist!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Name");
            }
        }

        public DataModels.EditProfileAgencyModel getEditDataAgency()
        {
            return dataEditResultAgency;
        }

        // Retrieve Edit Profile Data
        static DataModels.EditProfileEmployerModel dataEditResultEmployer;
        public async void RetrieveEmployerEditData(string firstname)
        {
            client = new FireSharp.FirebaseClient(config);

            if (firstname != null)
            {
                try
                {
                    response = await client.GetTaskAsync("Edit Profile Employer/" + firstname);
                    dataEditResultEmployer = response.ResultAs<DataModels.EditProfileEmployerModel>();
                }
                catch (Exception)
                {
                    MessageBox.Show("Name does not exist");
                }
            }
            else
            {
                MessageBox.Show("Invalid Name");
            }
        }

        public DataModels.EditProfileEmployerModel getEditDataEmployer()
        {
            return dataEditResultEmployer;
        }


        // Retrieve Housekeeper Edit Data
        static DataModels.EditProfileHkModel dataEditResultHk;
        public async void RetrieveHousekeeperEditData(string firstname)
        {
            client = new FireSharp.FirebaseClient(config);

            if (firstname != null)
            {
                try
                {
                    response = await client.GetTaskAsync("Edit Profile Housekeeper/" + firstname);
                    dataEditResultHk = response.ResultAs<DataModels.EditProfileHkModel>();
                }
                catch (Exception)
                {
                    MessageBox.Show("Name does not exist");
                }
            }
            else
            {
                MessageBox.Show("Invalid Name");
            }
        }

        public DataModels.EditProfileHkModel getEditDataHk()
        {
            return dataEditResultHk;
        }

        // Agency List and Housekeeping List Configuration

        public async void AgencyListData(string imageData, string agencyName, string agencyAddress)
        {
            client = new FireSharp.FirebaseClient(config);

            try
            {
                FirebaseResponse responseID = await client.GetTaskAsync("1AgencyList/activeNodes/");
                ActiveList_Counter.AgencyListCounter agencyId = responseID.ResultAs<ActiveList_Counter.AgencyListCounter>(); // retrieve data counter

                var agencyListData = new DataModels.AgencyListData
                {
                    AgencyID = (Convert.ToInt32(agencyId.count) + 1).ToString(), // counter incremented
                    AgencyName = agencyName,
                    AgencyAddress = agencyAddress,
                    ImageData = imageData
                };

                SetResponse reponseAgencyData = await client.SetTaskAsync("3AgencyListData/" + agencyListData.AgencyID, agencyListData);
                var resultAgencyData = reponseAgencyData.ResultAs<DataModels.AgencyListData>();

                var counter = new ActiveList_Counter.AgencyListCounter
                {
                    count = resultAgencyData.AgencyID
                };

                SetResponse responseCounter = await client.SetTaskAsync("1AgencyList/activeNodes/", counter);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); MessageBox.Show("Agency"); }
        }

        public async void UpdateAgencyList(string imageData, string agencyName, string placeAddress)
        {
            client = new FireSharp.FirebaseClient(config);

            FirebaseResponse responseID, responseAgency;

            try
            {
                // Housekeeping ID 
                responseID = await client.GetTaskAsync("1AgencyList/activeNodes/");
                var resultID = responseID.ResultAs<ActiveList_Counter.AgencyListCounter>();

                // Housekeeping Data 
                responseAgency = await client.GetTaskAsync("3AgencyListData/" + resultID.count);
                var resultDataAgency = responseAgency.ResultAs<DataModels.AgencyListData>();

                // Compare Data from user in put to firebase
                if ((resultID.count == resultDataAgency.AgencyID) && (agencyName == resultDataAgency.AgencyName))
                {
                    var agencyData = new DataModels.AgencyListData
                    {
                        AgencyID = resultID.count,
                        AgencyAddress = placeAddress,
                        AgencyName = agencyName,
                        ImageData = imageData

                    };

                    responseAgency = await client.UpdateTaskAsync("3AgencyListData/" + resultID.count, agencyData);
                    resultDataAgency = responseAgency.ResultAs<DataModels.AgencyListData>();

                    MessageBox.Show($"{resultDataAgency.AgencyName} updated");
                }
                else
                {
                    AgencyListData(imageData, agencyName, placeAddress);
                }
            }
            catch (Exception)
            {
                AgencyListData(imageData, agencyName, placeAddress);
            }

        }

        DataModels.HousekeepingListData resultHkData;
        public async void HousekeepingListData(string imageData, string hkName, string categorySkill)
        {
            client = new FireSharp.FirebaseClient(config);

            try
            {
                FirebaseResponse responseHk = await client.GetTaskAsync("2HousekeepingList/activeNodes/");
                var hkId = responseHk.ResultAs<ActiveList_Counter.HousekeepingListCounter>();

                var housekeepingListData = new DataModels.HousekeepingListData
                {
                    HousekeeperID = (Convert.ToInt32(hkId.count) + 1).ToString(),
                    HousekeeperName = hkName,
                    Category = categorySkill,
                    ImageData = imageData
                };

                SetResponse responseHkData = await client.SetTaskAsync("3HousekeepingListData/" + housekeepingListData.HousekeeperID, housekeepingListData);

                resultHkData = responseHkData.ResultAs<DataModels.HousekeepingListData>();

                var counter = new ActiveList_Counter.HousekeepingListCounter
                {
                    count = resultHkData.HousekeeperID
                };

                SetResponse responseCounter = await client.SetTaskAsync("2HousekeepingList/activeNodes/", counter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static DataModels.HousekeepingListData resultDataHk;
        static ActiveList_Counter.HousekeepingListCounter resultID;
        public async void UpdateHousekeepingList(string imageData, string hkName, string hkSkill)
        {
            client = new FireSharp.FirebaseClient(config);

            FirebaseResponse responseID, responseHk;

            try
            {
                // Housekeeping ID 
                responseID = await client.GetTaskAsync("2HousekeepingList/activeNodes/");
                resultID = responseID.ResultAs<ActiveList_Counter.HousekeepingListCounter>();

                // Housekeeping Data 
                responseHk = await client.GetTaskAsync("3HousekeepingListData/" + resultID.count);
                resultDataHk = responseHk.ResultAs<DataModels.HousekeepingListData>();

                // Compare Data from user in put to firebase
                if ((resultID.count == resultDataHk.HousekeeperID) && (hkName == resultDataHk.HousekeeperName))
                {
                    var hkData = new DataModels.HousekeepingListData
                    {
                        HousekeeperID = resultID.count,
                        Category = hkSkill,
                        HousekeeperName = hkName,
                        ImageData = imageData

                    };

                    responseHk = await client.UpdateTaskAsync("3HousekeepingListData/" + resultID.count, hkData);
                    resultDataHk = responseHk.ResultAs<DataModels.HousekeepingListData>();

                    MessageBox.Show($"{resultDataHk.HousekeeperName} updated");
                }
                else
                {
                    HousekeepingListData(imageData, hkName, hkSkill);
                }
            }
            catch(Exception)
            {
                HousekeepingListData(imageData, hkName, hkSkill);
            }
          
        }

        static DataTable dt = new DataTable();

        // Get Data Housekeeper
        public async void GetItemsTable()
        {
            client = new FireSharp.FirebaseClient(config);

            FirebaseResponse responseIdHkData = await client.GetTaskAsync("2HousekeepingList/activeNodes/");
            ActiveList_Counter.HousekeepingListCounter resultIdData = responseIdHkData.ResultAs<ActiveList_Counter.HousekeepingListCounter>();

           
            int cnt = Convert.ToInt32(resultIdData.count);

            int i = 0; 
            while (true)
            {
                i++;
                if (i == cnt)
                {
                    break; 
                }

                try
                {
                    FirebaseResponse responseDataHk2 = await client.GetTaskAsync("3HousekeepingListData/" + i);
                    DataModels.HousekeepingListData dataResultHk = responseDataHk2.ResultAs<DataModels.HousekeepingListData>();

                    DataRow row = dt.NewRow();
                    row["Name"] = dataResultHk.HousekeeperName;
                    row["Category"] = dataResultHk.Category;
                    row["ImageString"] = dataResultHk.ImageData;

                    dt.Rows.Add(row);
                }
                
                catch (Exception) { }
                
            }
        }

        // Get Data Agency
        public async void GetItemsTableAgency()
        {

            DataTable table = new DataTable();
            client = new FireSharp.FirebaseClient(config);

            FirebaseResponse responseIdAgencyData = await client.GetTaskAsync("1AgencyList/activeNodes/");
            ActiveList_Counter.AgencyListCounter resultIdData = responseIdAgencyData.ResultAs<ActiveList_Counter.AgencyListCounter>();


            int cnt = Convert.ToInt32(resultIdData.count);

            int i = 0;
            while (true)
            {
                i++;
                if (i == cnt)
                {
                    break;
                }
                
                try
                {
                    FirebaseResponse responseDataAgency = await client.GetTaskAsync("3AgencyListData/" + i);
                    DataModels.AgencyListData dataResultHk = responseDataAgency.ResultAs<DataModels.AgencyListData>();

                    DataRow row = table.NewRow();
                    row["name"] = dataResultHk.AgencyName;
                    row["place"] = dataResultHk.AgencyAddress;
                    row["imageString"] = dataResultHk.ImageData;

                    dt.Rows.Add(row);
                }

                catch (Exception) { }

            }
        }
    }
}
  
