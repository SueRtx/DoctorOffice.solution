using System.Collections.Generic;

namespace Office.Models
{
    public class Patient
    {
        public Patient()
        {
            this.JoinEntities = new HashSet<DoctorPatient>();
        }

        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string BirthDate { get; set; }
        public int SpecialtyId { get; set; }
        
        public virtual Specialty Specialty { get; set; }
        public virtual ICollection<DoctorPatient> JoinEntities { get;}
    }
}