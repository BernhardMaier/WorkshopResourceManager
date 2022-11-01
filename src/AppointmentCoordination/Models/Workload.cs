using System.Collections.Generic;

namespace AppointmentCoordination.Models
{
  public class Workload
  {
    public Workload(IEnumerable<Operation> operations)
    {
      Operations = operations;
    }
    
    public IEnumerable<Operation> Operations { get; }
  }
}