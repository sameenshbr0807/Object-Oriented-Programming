using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Admin
{
    internal class AdminRepository
    {
        private readonly string _file = "Admin.txt";
        public AdminRepository()
        {

        }
        public void SaveInFile(AdminModel admin)
        {
            using (StreamWriter writer = new StreamWriter(_file, true))
            {
                writer.WriteLine(admin.ToString());
            }
        }
        public void SaveAllDataInFile(List<AdminModel> admins)
        {
            File.WriteAllText(_file, string.Empty);
            foreach (AdminModel admin in admins)
            {
                SaveInFile(admin);
            }
        }
        public List<AdminModel> GetAdminFromUser()
        {
            List<AdminModel> adminList = new List<AdminModel>();
            if (!File.Exists(_file))
            {
                return adminList;
            }
            using (StreamReader reader = new StreamReader(_file))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    int doctorID = int.Parse(parts[0]);
                    string doctorName = parts[1];
                    int age = int.Parse(parts[2]);
                    string specialization = parts[3];
                    float consultationFee = float.Parse(parts[4]);
                    bool isAvailable = bool.Parse(parts[5]);
                    AdminModel adminModel = new AdminModel(doctorID, doctorName, age, specialization, consultationFee, isAvailable);
                    adminList.Add(adminModel);
                }
            }
            return adminList;
        }
    }
}
