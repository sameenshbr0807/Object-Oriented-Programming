using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Admin
{
    internal class AdminModel
    {
        private int doctorID;
        private string doctorName;
        private int age;
        private string specialization;
        private float consultationFee;
        private bool isAvailable;
        public AdminModel()
        {

        }
        public AdminModel(int doctorID,string doctorName,int age,string specialization,float consultationFee,bool isAvailable)
        {
           this.doctorID = doctorID;
           this.doctorName = doctorName;
           this.age = age;
           this.specialization = specialization;
           this.consultationFee = consultationFee;
           this.isAvailable = isAvailable;
        }
        public void SetDoctorID(int doctorID)
        {
            this.doctorID = doctorID;
        }
        public int GetDoctorID()
        {
            return doctorID;
        }
        public void SetDoctorName(string doctorName)
        {
            this.doctorName = doctorName;
        }
        public string GetDoctorName()
        {
            return doctorName;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetSpecialization(string specialization)
        {
            this.specialization = specialization;
        }
        public string GetSpecialization()
        {
            return specialization;
        }
        public void SetConsultationFee(float consultationFee)
        {
            this.consultationFee = consultationFee;
        }
        public float GetConsultationFee()
        {
            return consultationFee;
        }
        public void SetIsAvailable(bool isAvailable)
        {
            this.isAvailable = isAvailable;
        }
        public bool GetIsAvailable()
        {
            return isAvailable;
        }
        public override string ToString()
        {
            return doctorID +","  + doctorName +"," + age +"," + specialization +"," + consultationFee +"," + isAvailable;
        }
    }
}
