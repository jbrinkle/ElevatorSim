using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorsim.Simulator
{
    public class Simulator
    {
        private List<Elevator> _elevators;
        private IElevatorRequestReceiver _dispatcher;
        private IElevatorLandscape _landscape;

        public Simulator(int elevatorCount, int floorCount)
        {
            // create landscape

            _elevators = new List<Elevator>();

            for (var e = 0; e < elevatorCount; e++)
            {
                var elevator = new Elevator(null/* placeholder for status receiver */, (uint)e, 0, floorCount);
            }

            _dispatcher = new ElevatorDispatcher(_landscape, _elevators);

        }
    }
}
