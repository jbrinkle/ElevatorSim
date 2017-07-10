using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorsim.Simulator
{
    public class ElevatorLocator : IElevatorLocator
    {
        private List<Elevator> _elevators;

        public ElevatorLocator(List<Elevator> elevatorsToManage)
        {
            _elevators = elevatorsToManage;
        }

        public Elevator FindNearestElevatorToFloor(int floor, bool directionUp)
        {
            // do some logic here to calculate best elevator for service

            // of the ones that are in service, priority order:
            // 1. Unoccupied on the floor
            // 2. Elevators moving in the correct direction and towards the floor
            // 3. Nearest unoccupied
            // 4. Random - don't want to fall between the cracks!

            return null;
        }
    }
}
