using System.Collections.Generic;

namespace Office.Models
{
public class Specialty
  {
    public Specialty()
    {
      this.Doctors = new HashSet<Doctor>();
      this.Patients = new HashSet<Patient>();
    }

    public int SpecialtyId { get; set; }
    public string Name { get; set; }
    
    public virtual ICollection<Doctor> Doctors { get; set; }
    public virtual ICollection<Patient> Patients { get; set; }
  }
}