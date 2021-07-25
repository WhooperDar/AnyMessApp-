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

            if(name != null && address != null && address != null && contact != null && website != null && agencyCode != null)
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

            if(username != null && firstname != null && email != null && password != null && confirmpass != null)
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
        private async void SavaEditProfileAgency(string agencyName, string imageAgencyData, string aboutUs, string addressData, string websiteData, string agencyContact, string agencyLookingfor)
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
        private async void SaveEditProfileEmployer(string employerName, string imageAgencyData, string aboutMe, string addressData, string emailData, string contactNumber, string lookingFor)
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
                catch(Exception ex)
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
        private async void SaveEditProfileHousekeeper(string firstName, string rateHk, string imageHkData, string aboutMeHk, string addressHk, string contactNumber, string emailHk, string skill)
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
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Invalid Input!");
            }
        }


        /* public string AgencyName { get; set; }
         public string ImageAgencyData { get; set; }
         public string AboutUs { get; set; }
         public string AddressData { get; set; }
         public string WebsiteData { get; set; }
         public string AgencyContact { get; set; }
         public string AgencyLookingFor { get; set; }*/

        // Agency
        FirebaseResponse response;
        static Data dataAgencyResult;
        public async void fetchAgencyDataDB(string name)
        {
            client = new FireSharp.FirebaseClient(config);   

            if(name != null)
            {
                try
                {
                    response = await client.GetTaskAsync("Agency Information/" + name);
                    dataAgencyResult = response.ResultAs<Data>();
                }
                catch(Exception)
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

            if(name != null)
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

            if(name != null)
            {
                try
                {
                    response = await client.GetTaskAsync("Housekeeper Information/"+name);
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

            if(username != null)
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
    }
}
