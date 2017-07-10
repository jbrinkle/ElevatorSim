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
        private int _floorOdometer;
        private int _floorTripmeter;
        private IElevatorStatusReceiver _statusReceiver;

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
            _statusReceiver = statusReceiver;
        }

        public void AddStop(int floor)
        {
            if (Intent == IntentStatus.OutOfService)
            {
                throw new InvalidOperationException("Out of service!");
            }

            // want to maintain the order intended for the stops.
            // come back and change logic to use insert to maintain a sane ordering
            _stops.Add(floor);
        }

        public void SimulateTimePassing()
        {
            switch (Intent)
            {
                case IntentStatus.MovingUp:
                case IntentStatus.MovingDown:
                    // Simulators need to simulate time passing and keep other objects synchronized
                    // assuming SimulateTimePassing represents a unit of time...
                    // call MoveOneFloor, OpenDoors, CloseDoors as needed
                case IntentStatus.Unoccupied:
                case IntentStatus.OutOfService:
                default:
                    break;
            }
        }

        private void MoveOneFloor()
        {
            // wait until all people have disembarked before shutting down elevator
            // Bug: During busy times, elevator might over-extend itself because it won't have time to come out of rotation before getting new assignments
            //      Create IsAvailable property that can take floorTripmeter and Intent into consideration to prevent future assignments
            if (_floorTripmeter >= 100 && Intent == IntentStatus.Unoccupied)
            {
                Intent = IntentStatus.OutOfService;
                _statusReceiver.ReportMaintenanceNeeded(Id);
            }

            if (Intent == IntentStatus.MovingUp)
            {
                // check if we can go up anymore
                // move up if yes
                _floorOdometer++;
                _floorTripmeter++;
            }
            else if (Intent == IntentStatus.MovingDown)
            {
                // check if we can go down anymore
                // move down if yes
                _floorOdometer++;
                _floorTripmeter++;
            }
            
        }

        private void OpenDoors()
        {
            // pop destination
            _statusReceiver.ReportDoorOperation(Id, true);
        }

        private void CloseDoors()
        {
            _statusReceiver.ReportDoorOperation(Id, false);
        }
    }
}
