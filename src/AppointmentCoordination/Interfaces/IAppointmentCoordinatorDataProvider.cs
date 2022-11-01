using System.Collections.Generic;
using AppointmentCoordination.Models;
using CSharpFunctionalExtensions;

namespace AppointmentCoordination.Interfaces
{
  public interface IAppointmentCoordinatorDataProvider
  {
    Result<IEnumerable<Appointment>> GetAppointments();
    Result<IEnumerable<Worker>> GetWorkers();
    Result<IEnumerable<Workplace>> GetWorkplaces();
    Result<IEnumerable<Tool>> GetTools();
  }
}