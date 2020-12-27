using System;

namespace ConsoleApp1
{
    public class Players: IPlayerDescription
    {
        private string _name;
        private string _club;
        private string _position;

        public Players() { }
        public Players(string name, string club, string position) 
        {
            _name = name;
            _club = club;
            _position = position;      
        }


        public string PlayerDescription()
        {
            return $"{_name} plays as a {_position} at {_club}";
        }

        static void Main(string[] args)
        {
            Players DeclanRice = new Players("Declan Rice", "West Ham", "Midfielder");
            Console.WriteLine(DeclanRice.PlayerDescription());
        }

    }
}
