using System.Collections.Generic;

namespace Office.Models
{
    public class Patient
    {
        public Patient()
        {
            this.JoinEntities = new HashSet<PatientDoctor>();
        }

        public int PatientId { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public int SpecialtyId { get; set; }
        
        public virtual Specialty Specialty { get; set; }
        public virtual ICollection<PatientDoctor> JoinEntities { get;}
    }
}