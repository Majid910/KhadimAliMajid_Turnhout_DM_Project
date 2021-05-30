using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieConnector
{
    public class Person
    {
        private int id;
        private string character;
        private string name;
        private string profilePath;
        private byte[] image;

        public Person(int id, string character, string name, string profilePath)
        {
            this.id = id;
            this.character = character;
            this.name = name;
            this.profilePath = profilePath;
        }

        public Person(int id, string character, string name, byte[] image)
        {
            this.id = id;
            this.character = character;
            this.name = name;
            this.image = image;
        }

        public int Id { get { return id; } }

        public string Character { get { return character; } }

        public string Name { get { return name; } }

        public string ProfilePath { get { return profilePath; } }

        public byte[] Image { get { return image; } }
    }
}
