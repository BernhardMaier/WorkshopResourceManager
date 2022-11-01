using System;
using System.Collections.Generic;
using AppointmentCoordination.Interfaces;
using AppointmentCoordination.Models;
using CSharpFunctionalExtensions;

namespace AppointmentCoordination
{
  public class AppointmentCoordinator : IAppointmentCoordinator
  {
    private readonly IAppointmentCoordinatorDataProvider _dataProvider;

    public AppointmentCoordinator(IAppointmentCoordinatorDataProvider dataProvider) =>
      _dataProvider = dataProvider;

    public Result<IReadOnlyList<Appointment>> FindAppointmentsFor(Workload workload) => throw new NotImplementedException();
  }
}