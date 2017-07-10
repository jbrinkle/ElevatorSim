using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorsim.Simulator
{
    public class ElevatorLandscape : IElevatorLandscape, IElevatorStatusReceiver
    {
        // This is a code smell - This is possibly going to require duplication of a data structure. 
        // Reviewing spec again... Elevator can "report" floor, door state via properties on the elevator object

        public uint FindNearestElevatorToFloor(int floor)
        {
            throw new NotImplementedException();
        }

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
