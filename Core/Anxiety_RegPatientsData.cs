using Core.IDataContext;
namespace Core
{
using Core.Models;
using System.Collections.Generic;

public class Anxiety_RegPatientsData : IAnxiety_RegPatient
{
    private readonly AnxietyEntities _db;
    public Anxiety_RegPatientsData(AnxietyEntities db)
    {
        _db=db;
    }

    public void AddPatients(Anxiety_RegPatient reg)
    {
        _db.Anxiety_RegPatients.Add(reg);
        _db.SaveChanges();
    }

    public void DeletePatients(int id)
    {
        var data=_db.Anxiety_RegPatients.FirstOrDefault(x => x.Pid == id);
        _db.Anxiety_RegPatients.Remove(data);
        _db.SaveChanges();
    }


    public void EditPatients(Anxiety_RegPatient reg)
    {
        _db.Anxiety_RegPatients.Update(reg);
        _db.SaveChanges();
    }

        public List<Anxiety_RegPatient> GetPatientById(int id)
        {
            List<Anxiety_RegPatient> data = _db.Anxiety_RegPatients.Where(x => x.Pid == id).ToList();
            return data;
        }

        public IEnumerable<Anxiety_RegPatient> GetPatients()
    {
        return _db.Anxiety_RegPatients.ToList();
    }

       
    }
}
