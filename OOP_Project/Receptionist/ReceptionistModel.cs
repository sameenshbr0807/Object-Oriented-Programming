using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Receptionist
{
    internal class ReceptionistModel
    {
        private int patientID;
        private string patientName;
        private int age;
        private string gender;
        private string disease;
        private int roomNumber;
        private string appointmentDate;
        private float billAmount;
        public ReceptionistModel()
        {
            patientID = 0;
            patientName="";
            age = 0;
            gender = "";
            disease = "";
            roomNumber = 0;
            appointmentDate = "";
            billAmount = 0;
        }
        public ReceptionistModel(int patientID,string patientName,int age,string gender,string disease,int roomNumber,string appointmentDate,float billAmount)
        {
            this.patientID = patientID;
            this.patientName = patientName;
            this.age = age;
            this.gender = gender;
            this.disease = disease;
            this.roomNumber = roomNumber;
            this.appointmentDate = appointmentDate;
            this.billAmount = billAmount;
        }
        public int GetPatientID()
        {
            return patientID;
        }
        public void SetPatientID(int patientID)
        {
            this.patientID = patientID;
        }
        public string GetPatientName()
        {
            return patientName;
        }
        public void SetPatientName(string patientName)
        {
            this.patientName= patientName;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public string GetGender()
        {
            return gender;
        }
        public void SetGender(string gender)
        {
            this.gender = gender;
        }
        public string GetDisease()
        {
            return disease;
        }
        public void SetDisease(string disease)
        {
            this.disease= disease;
        }
        public int GetRoomNumber()
        {
            return roomNumber;
        }
        public void SetRoomNumber(int roomNumber)
        {
            this.roomNumber = roomNumber;
        }
        public string GetAppointmentDate()
        {
            return appointmentDate;
        }
        public void SetAppointmentDate(string appointmentDate)
        {
            this.appointmentDate = appointmentDate;
        }
        public float GetBillAmount()
        {
            return billAmount;
        }
        public void SetBillAmount(float billAmount)
        {
            this.billAmount = billAmount;
        }
        public override string ToString()
        {
            return + patientID + "," + patientName + "," + age + "," + gender + "," + disease + "," + roomNumber + ","  +appointmentDate + ","  +billAmount;
        }
    }
}
