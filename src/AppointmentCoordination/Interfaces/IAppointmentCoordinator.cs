using AppointmentCoordination.Models;
using CSharpFunctionalExtensions;

namespace AppointmentCoordination.Interfaces
{
  public interface IAppointmentCoordinator
  {
    Result<Appointment> FindAppointmentFor(Workload workload, IAppointmentCoordinatorDataProvider dataProvider);
  }
}