using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorsim.Simulator
{
    public class ElevatorDispatcher : IElevatorRequestReceiver
    {
        private IElevatorLandscape _landscape;
        private List<Elevator> _elevators;

        public ElevatorDispatcher(IElevatorLandscape landscape, List<Elevator> elevators)
        {
            _landscape = landscape;
            _elevators = elevators;
        }

        public void Request(int floor)
        {
            // TODO: error checking

            var eid = _landscape.FindNearestElevatorToFloor(floor);
            var elevator = _elevators.Single(e => e.Id == eid);

            elevator.AddStop(floor);
        }
    }
}
