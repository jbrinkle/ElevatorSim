using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorsim.Simulator
{
    public class Elevator
    {
        public uint Id { get; private set; }

        public Elevator(IElevatorStatusReceiver statusReceiver, uint id, int minFloor, int maxFloor)
        {

        }

        public void AddStop(int floor)
        {

        }
    }
}
