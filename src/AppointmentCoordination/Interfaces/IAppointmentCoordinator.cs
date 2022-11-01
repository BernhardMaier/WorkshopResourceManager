using System.Collections.Generic;
using AppointmentCoordination.Models;
using CSharpFunctionalExtensions;

namespace AppointmentCoordination.Interfaces
{
  public interface IAppointmentCoordinator
  {
    Result<IReadOnlyList<Appointment>> FindAppointmentsFor(Workload workload);
  }
}