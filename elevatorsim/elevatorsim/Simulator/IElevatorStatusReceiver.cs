using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorsim.Simulator
{
    /// <summary>
    /// Receives status updates from elevators
    /// </summary>
    public interface IElevatorStatusReceiver
    {
        /// <summary>
        /// Report position of an elevator
        /// </summary>
        /// <param name="elevatorId">The id of the elevator</param>
        /// <param name="floor">The current floor of the elevator</param>
        void ReportPosition(uint elevatorId, int floor);

        /// <summary>
        /// Report door status for an elevator
        /// </summary>
        /// <param name="evelatorId">The id of the elevator</param>
        /// <param name="doorOpened">The current door status.</param>
        void ReportDoorOperation(uint evelatorId, bool doorOpened);

        /// <summary>
        /// Report maintenance requirement for an elevator
        /// </summary>
        /// <param name="elevatorId">The id of the elevator</param>
        void ReportMaintenanceNeeded(uint elevatorId);
    }
}
