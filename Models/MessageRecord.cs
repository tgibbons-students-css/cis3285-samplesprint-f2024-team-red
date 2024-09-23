namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        public MessageRecord(int roomID, string authorName, string text)
        {
            // Changes for Sprint 2 -- User Story 2A -- Lonnie Golen
            // Changes Sprint 2 -- As a message poster, I want to send markdown text that will be correctly formatted. --Lonnie Golen
            RoomID = roomID;
            Text = text;
            AuthorName = authorName;
        }

        public int RoomID
        {
            get;
            private set;
        }

        public string Text
        {
            // Changes for Sprint 2 -- User Story 2A -- Lonnie Golen
            // Changes Sprint 2 -- As a message poster, I want to send markdown text that will be correctly formatted. --Lonnie Golen
            get;
            private set;
        }

        public string AuthorName
        {
            get;
            private set;
        }
    }
}
