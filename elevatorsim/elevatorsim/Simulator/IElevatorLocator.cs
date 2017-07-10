using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorsim.Simulator
{
    /// <summary>
    /// Understands elevator positions and can locate them relative to other locations
    /// </summary>
    public interface IElevatorLocator
    {
        /// <summary>
        /// Find the elevator most likely to be quickest at servicing a floor
        /// </summary>
        /// <param name="floor">The floor where an elevator is needed</param>
        /// <param name="directionUp">User intends to go up.</param>
        /// <returns>The elevator that can best service the request</returns>
        Elevator FindNearestElevatorToFloor(int floor, bool directionUp);
    }
}
