using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorsim.Simulator
{
    /// <summary>
    /// Class for recording trips and other data for analytical purposes
    /// </summary>
    public class ElevatorRecorder : IElevatorStatusReceiver
    {
        public void ReportDoorOperation(uint evelatorId, bool doorOpened)
        {
            throw new NotImplementedException();
        }

        public void ReportMaintenanceNeeded(uint elevatorId)
        {
            throw new NotImplementedException();
        }

        public void ReportPosition(uint elevatorId, int floor)
        {
            throw new NotImplementedException();
        }
    }
}
