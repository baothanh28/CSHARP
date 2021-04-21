using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegateCSharp
{
    public class RoomConstraints
    {
        private EventHandler<string> _buildRoomListEvent;
        private EventHandler<string> _buildSpaceConstraint;

        private List<AddClassRoomTypeA> _roomTypeA;
        private List<AddClassRoomTypeB> _roomTypeB;

        private void BuildClassRoomList()
        {
            Console.WriteLine("I am buildding ClassroomList \n");
            if (_buildRoomListEvent != null)
            {
                _buildRoomListEvent.Invoke(this,"build conditions");
            }

        }
        private void BuildSpaceConstrainst()
        {
            Console.WriteLine("I am buildding Space Constraints  \n");
            if(_buildSpaceConstraint != null)
            {
                _buildSpaceConstraint.Invoke(this, "build constraints");
            }
        }
        public void BuildXml()
        {
            BuildClassRoomList();
            BuildSpaceConstrainst();
        }
        public void WithAddRoomTypeA(List<AddClassRoomTypeA> listA)
        {
            _roomTypeA = listA;
            //_buildRoomListEvent += WithAddRoomTypeBEvent;
            _buildSpaceConstraint += WithAddConstaintTypeAEvent;
        }
        public void WithAddRoomTypeB(List<AddClassRoomTypeB> listB)
        {
            _roomTypeB = listB;
            _buildRoomListEvent += WithAddRoomTypeBEvent;
            _buildSpaceConstraint += WithAddConstaintTypeBEvent;      
        }
        private void WithAddRoomTypeBEvent(object sender,string condition)
        {
            Console.WriteLine("\n");
            if(_roomTypeB != null)
            {
                for (int i = 0; i < _roomTypeB.Count; i++)
                {
                    Console.WriteLine($"Day la build List Phong B: {_roomTypeB[i].BuildingName} {condition}\n");
                }
            }
            
        }
        private void WithAddConstaintTypeBEvent(object sender, string constraints)
        {
            Console.WriteLine("\n");
            if (_roomTypeB != null)
            {
                for (int i = 0; i < _roomTypeB.Count; i++)
                {
                    Console.WriteLine($"Day la build rang buoc Phong B: {_roomTypeB[i].ClassRoom} {constraints} \n");
                }
            }

        }

        private void WithAddConstaintTypeAEvent(object sender, string constraints)
        {
            Console.WriteLine("\n");
            if (_roomTypeA != null)
            {
                for (int i = 0; i < _roomTypeA.Count; i++)
                {
                    Console.WriteLine($"Day la build rang buoc Phong A: {_roomTypeA[i].ClassRoom} {constraints} \n");
                }
            }

        }
    }
}
