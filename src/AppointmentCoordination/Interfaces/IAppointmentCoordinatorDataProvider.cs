using System.Collections.Generic;
using AppointmentCoordination.Models;
using CSharpFunctionalExtensions;

namespace AppointmentCoordination.Interfaces
{
  public interface IAppointmentCoordinatorDataProvider
  {
    Result<IReadOnlyList<Appointment>> GetAppointments();
    Result<IReadOnlyList<Worker>> GetWorkers();
    Result<IReadOnlyList<Workplace>> GetWorkplaces();
    Result<IReadOnlyList<Tool>> GetTools();
  }
}