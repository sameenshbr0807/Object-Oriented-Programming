using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Receptionist
{
    internal class ReceptionistRepository
    {
            private readonly string _file = "Receptionist.txt";

            public ReceptionistRepository()
            {

            }

            public void SaveInFile(ReceptionistModel receptionist)
            {
                using (StreamWriter writer = new StreamWriter(_file, true))
                {
                    writer.WriteLine(receptionist.ToString());
                }
            }

            public void SaveAllDataInFile(List<ReceptionistModel> receptionists)
            {
                File.WriteAllText(_file, string.Empty);

                foreach (ReceptionistModel receptionist in receptionists)
                {
                    SaveInFile(receptionist);
                }
            }

            public List<ReceptionistModel> GetReceptionistFromFile()
            {
                List<ReceptionistModel> receptionistList =
                    new List<ReceptionistModel>();

                if (!File.Exists(_file))
                {
                    return receptionistList;
                }

                using (StreamReader reader = new StreamReader(_file))
                {
                    string line = " ";

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        int patientID = int.Parse(parts[0]);
                        string patientName = parts[1];
                        int age = int.Parse(parts[2]);
                        string gender = parts[3];
                        string disease = parts[4];
                        int roomNumber = int.Parse(parts[5]);
                        string appointmentDate = parts[6];
                        float billAmount = float.Parse(parts[7]);

                    ReceptionistModel receptionistModel = new ReceptionistModel(patientID, patientName, age, gender, disease, roomNumber, appointmentDate, billAmount);
                        receptionistList.Add(receptionistModel);
                    }
                }

                return receptionistList;
            }
        }
    }

