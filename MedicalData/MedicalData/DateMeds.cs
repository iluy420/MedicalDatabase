using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalData
{
    class DateMeds
    {
        private int PatientNumber { get; set; }
        private string Surname, Name, Patronymic;

        public DateMeds() { }
        public DateMeds(string Surname, string Name, string Patronymic) {
            this.Surname = Surname;
            this.Name = Name;
            this.Patronymic = Patronymic;
        }
    }
}
