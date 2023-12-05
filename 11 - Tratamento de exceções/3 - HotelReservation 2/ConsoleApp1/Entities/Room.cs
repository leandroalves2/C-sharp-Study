namespace ConsoleApp1.Entities
{
    internal class Room
    {
        public int Number { get; set; }
        public bool Reserved { get; set; }

        public Room()
        {
        }
        public Room(int number, bool reserved)
        {
            Number = number;
            Reserved = reserved;
        }
    }
}