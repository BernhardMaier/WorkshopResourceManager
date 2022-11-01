using System;
using AppointmentCoordination.Interfaces;
using AppointmentCoordination.Models;
using CSharpFunctionalExtensions;

namespace AppointmentCoordination
{
  public class AppointmentCoordinator : IAppointmentCoordinator
  {
    public Result<Appointment> FindAppointmentFor(Workload workload, IAppointmentCoordinatorDataProvider dataProvider) => throw new NotImplementedException();
  }
}