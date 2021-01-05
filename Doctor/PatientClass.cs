using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor
{
    class PatientClass
    {
        private string p_name;
        private string p_username;
        private string p_contract;
        private string p_email;
        private string p_password;
        private string p_area;
        private string p_age;
        private string p_gender;

        public string P_name { get => p_name; set => p_name = value; }
        public string P_username { get => p_username; set => p_username = value; }
        //public string P_contract { get => p_contract; set => p_contract = value; }
        public string P_email { get => p_email; set => p_email = value; }
        public string P_password { get => p_password; set => p_password = value; }
        public string P_area { get => p_area; set => p_area = value; }
       // public string P_age { get => p_age; set => p_age = value; }
        public string P_gender { get => p_gender; set => p_gender = value; }

    }
}
