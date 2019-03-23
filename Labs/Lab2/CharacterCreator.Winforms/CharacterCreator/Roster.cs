/*
 * Michael Alexander
 * ITSE 1430-21722
 * 3-16-19
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Roster
    {
        private readonly List<Character> _items = new List<Character>();
        private int _nextId = 0;

        public Character Add(Character character)
        {
            if (character == null)
                throw new ArgumentNullException(nameof(character));

            var existing = GetIndex(character.Name);
            if (existing >= 0)
                throw new Exception("Character must be unique");

            character.Id = ++_nextId;
            _items.Add(Clone(character));

            return character;
        }

        public Character Update(int id, Character character)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");
            if (character == null)
                throw new ArgumentNullException(nameof(character));

            var index = GetIndex(id);
            if (index < 0)
                throw new Exception("character does not exist.");

            //character names must be unique            
            var existingIndex = GetIndex(character.Name);
            if (existingIndex >= 0 && existingIndex != index)
                throw new Exception("character must be unique.");

            character.Id = id;
            var existing = _items[index];
            Clone(existing, character);

            return character;
        }

        public IEnumerable<Character> GetAll()
        {
            var temp = new List<Character>();
            foreach (var item in _items)
                temp.Add(Clone(item));

            return temp.ToArray();
        }

        public void Delete(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "ID must be > 0");

            var index = GetIndex(id);
            if (index >= 0)
                _items.RemoveAt(index);
        }

        public Character Get(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "ID must be > 0");

            var index = GetIndex(id);
            if (index >= 0)
                return Clone(_items[index]);

            return null;
        }

        private int GetIndex(string name)
        {
            for (var index = 0; index < _items.Count; ++index)
                if (String.Compare(_items[index]?.Name, name, true) == 0)
                    return index;

            return -1;
        }

        private int GetIndex(int id)
        {
            for (var index = 0; index < _items.Count; ++index)
                if (_items[index]?.Id == id)
                    return index;

            return -1;
        }

        private Character Clone(Character Character)
        {
            var newCharacter = new Character();
            Clone(newCharacter, Character);

            return newCharacter;
        }

        private void Clone(Character target, Character source)
        {
            target.Id = source.Id;
            target.Name = source.Name;
            target.Race = source.Race;
            target.Profession = source.Profession;
            target.Strength = source.Strength;
            target.Intelligence = source.Intelligence;
            target.Agility = source.Agility;
            target.Constitution = source.Constitution;
            target.Charisma = source.Charisma;
            target.Description = source.Description;
        }
    }
}
