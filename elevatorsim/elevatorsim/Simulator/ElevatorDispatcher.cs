using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorsim.Simulator
{
    public class ElevatorDispatcher : IElevatorRequestReceiver
    {
        private IElevatorLocator _locator;

        public ElevatorDispatcher(IElevatorLocator landscape)
        {
            _locator = landscape;
        }

        public void Request(int floor, bool directionUp)
        {
            // TODO: error checking

            var elevator = _locator.FindNearestElevatorToFloor(floor, directionUp);

            elevator.AddStop(floor);
        }
    }
}
