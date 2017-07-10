using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorsim.Simulator
{
    public class Elevator : ISimulatedObject
    {
        private int _minFloor;
        private int _maxFloor;
        private List<int> _stops;

        public enum IntentStatus
        {
            Unoccupied,
            MovingUp,
            MovingDown,
            OutOfService
        }

        public enum DoorStatus
        {
            Open,
            Closed
        }

        public uint Id { get; private set; }

        public IntentStatus Intent { get; private set; }

        public DoorStatus Door { get; private set; }

        public int CurrentFloor { get; private set; }

        public Elevator(IElevatorStatusReceiver statusReceiver, uint id, int minFloor, int maxFloor)
        {
            Id = id;
            _minFloor = minFloor;
            _maxFloor = maxFloor;
            _stops = new List<int>();
        }

        public void AddStop(int floor)
        {
            // want to maintain the order intended for the stops.
            // come back and change logic to use insert to maintain a sane ordering
            _stops.Add(floor);
        }

        public void SimulateTimePassing()
        {
            throw new NotImplementedException();

            // Simulators need to simulate time passing and keep other objects synchronized
            // assuming SimulateTimePassing represents a unit of time...
            // call MoveOneFloor, OpenDoors, CloseDoors as needed
        }

        private void MoveOneFloor()
        { }

        private void OpenDoors()
        { }

        private void CloseDoors()
        { }
    }
}
