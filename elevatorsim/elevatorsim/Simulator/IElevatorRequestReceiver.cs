using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorsim.Simulator
{
    /// <summary>
    /// Receives requests for elevator pickup
    /// </summary>
    public interface IElevatorRequestReceiver
    {
        /// <summary>
        /// Request an elevator pickup
        /// </summary>
        /// <param name="floor">The floor where the pickup is requested</param>
        void Request(int floor);
    }
}
