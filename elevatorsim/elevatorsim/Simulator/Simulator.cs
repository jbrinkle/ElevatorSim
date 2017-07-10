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
        private IElevatorLocator _locator;
        private IElevatorStatusReceiver _recorder;

        public Simulator(int elevatorCount, int floorCount)
        {
            _recorder = new ElevatorRecorder();

            _elevators = new List<Elevator>();

            for (var e = 0; e < elevatorCount; e++)
            {
                var elevator = new Elevator(_recorder, (uint)e, 0, floorCount);
            }

            _locator = new ElevatorLocator(_elevators);
            _dispatcher = new ElevatorDispatcher(_locator);

        }

        public void StartSimulation()
        {
            while (true)
            {
                // do stuff like send requests to _dispatcher
                // and make elevators simulate behavior
            }
        }

        public void EndSimulation()
        {
            // have recorder write out data to disk for analysis
            // - avg wait times
            // - elevator utilization
        }
    }
}
