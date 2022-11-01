using System.Collections.Generic;
using AppointmentCoordination.Interfaces;
using AppointmentCoordination.Models;
using CSharpFunctionalExtensions;

namespace AppointmentCoordination
{
  class AppointmentCoordinatorDataProvider : IAppointmentCoordinatorDataProvider
  {
    public Result<IEnumerable<Appointment>> GetAppointments() => throw new System.NotImplementedException();
    public Result<IEnumerable<Worker>> GetWorkers() => throw new System.NotImplementedException();
    public Result<IEnumerable<Workplace>> GetWorkplaces() => throw new System.NotImplementedException();
    public Result<IEnumerable<Tool>> GetTools() => throw new System.NotImplementedException();
  }
}