using System.Collections.Generic;

namespace Office.Models
{
    public class Doctor
    {
        public Doctor()
        {
            this.JoinEntities = new HashSet<PatientDoctor>();
        }

        public int DoctorId { get; set; }
        public string Name { get; set; }
        public int SpecialtyId { get; set; }

        public virtual Specialty Specialty { get; set; }
        public virtual ICollection<PatientDoctor> JoinEntities { get; set; }
    }
}