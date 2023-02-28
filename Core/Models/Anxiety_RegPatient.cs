using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Anxiety_RegPatient
    {
        [Key]
        public int Pid { get; set; }
        public string Pfirstname { get; set; }
        public string Plastname { get; set; }
        public int Page { get; set; }
        public string Pgender { get; set; }
        public string Pdob { get; set; }
        public string Paddress { get; set; }
        public string Pstate { get; set; }
        public string Pcity { get; set; }
        public string Pcontact { get; set; }
        public string Prefferalname { get; set; }
        public string Pbloodgroup { get; set; }
        public string Ppassword { get; set; }
        public string Pemail { get; set; }
        public int Rid { get; set; }












    }
}
