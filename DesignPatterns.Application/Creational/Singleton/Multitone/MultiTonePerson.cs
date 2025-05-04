namespace DesignPatterns.Application.Creational.Singleton.Multitone
{
    public class MultiTonePerson
    {
        public GenderEnum Gender { get; set; }

        private static readonly Dictionary<GenderEnum, MultiTonePerson> _people = new();

        private MultiTonePerson() { }

        public static MultiTonePerson GetPerson(GenderEnum gender)
        {
            if (_people.ContainsKey(gender))
            {
                return _people[gender];
            }

            var person = new MultiTonePerson();
            person.Gender = gender;
            _people.Add(gender, new MultiTonePerson());

            return person;
        }
    }
}
