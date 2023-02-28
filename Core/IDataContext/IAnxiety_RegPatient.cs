using Core.Models;

namespace Core.IDataContext
{
    public interface IAnxiety_RegPatient
    {
        public IEnumerable<Anxiety_RegPatient> GetPatients();
        public void AddPatients(Anxiety_RegPatient reg);
        public void EditPatients(Anxiety_RegPatient reg);
        public void DeletePatients(int id);
        public List<Anxiety_RegPatient> GetPatientById(int id);
    }
}
