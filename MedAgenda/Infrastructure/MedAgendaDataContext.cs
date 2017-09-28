using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web;
using MedAgenda.Models;

namespace MedAgenda.Infrastructure
{
    public class MedAgendaDataContext : DbContext
    {
        public MedAgendaDataContext() : base("MedAgenda")
        {

        }

        public System.Data.Entity.DbSet<MedAgenda.Models.Patient> Patients { get; set; }
    }
}