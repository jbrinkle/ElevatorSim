using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorsim.Simulator
{
    public interface IElevatorStatusReceiver
    {
        void ReportPosition(uint elevatorId, int floor);
        void ReportDoorOperation(uint evelatorId, bool doorOpened);
        void ReportMaintenanceNeeded(uint elevatorId);
    }
}
