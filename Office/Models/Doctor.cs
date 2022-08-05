using System.Collections.Generic;

namespace Office.Models
{
    public class Doctor
    {
        public Doctor()
        {
            this.JoinEntities = new HashSet<DoctorPatient>();
        }

        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public int SpecialtyId { get; set; }

        public virtual Specialty Specialty { get; set; }
        public virtual ICollection<DoctorPatient> JoinEntities { get; set; }
    }
}