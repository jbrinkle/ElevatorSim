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
    public interface IElevatorLandscape
    {
        /// <summary>
        /// Find the elevator most likely to be quickest at servicing a floor
        /// </summary>
        /// <param name="floor">The floor where an elevator is needed</param>
        /// <returns>The id of the elevator that can best service the request</returns>
        uint FindNearestElevatorToFloor(int floor);
    }
}
