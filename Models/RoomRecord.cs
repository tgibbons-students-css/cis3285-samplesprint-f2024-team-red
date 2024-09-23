namespace CIS3285_Unit3Sample_2024.Models
{
    public class RoomRecord
    {
        public RoomRecord(string name, int roomId)
        {
            // Changes for Sprint 1 -- User Story 1A -- Lonnie Golen
            // Changes Sprint 1 -- I want to create rooms for categorizing conversations --Lonnie Golen
            Name = name;
            RoomId1 = roomId;
        }

        int RoomId;
        public int RoomId1 { get => RoomId; set => RoomId = value; }

        public string Name
        {
            get;
            private set;
        }
    }
}
