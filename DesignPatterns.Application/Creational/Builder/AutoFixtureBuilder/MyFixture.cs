using System.Reflection;

namespace DesignPatterns.Application.Creational.Builder.AutoFixtureBuilder
{
    public class MyFixture
    {
        private ValueGenerator _generator;
        public MyFixture()
        {
            _generator = new ValueGenerator();
        }

        public T Create<T>() where T : class, new()
        {
            var objCreated = new T();
            SetDefaultValues(objCreated);
            return objCreated;
        }

        public FixtureBuilder<T> Build<T>() where T : class, new()
        {
            return new FixtureBuilder<T>();
        }

        private void SetDefaultValues(object obj)
        {
            var type = obj.GetType();
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
              .Where(x => x.CanWrite)
              .ToList();
            foreach (var prop in properties)
            {
                var propType = prop.PropertyType;
                if (propType == typeof(string))
                {
                    prop.SetValue(obj, _generator.GenerateString());
                }
                else if (propType == typeof(int))
                {
                    prop.SetValue(obj, _generator.GenerateInt());
                }
                else if (propType == typeof(bool))
                {
                    prop.SetValue(obj, _generator.GenerateBool());
                }
                else if (propType == typeof(DateTime))
                {
                    prop.SetValue(obj, _generator.GenerateDateTime());
                }
                else if (propType.IsClass && propType.GetConstructor(Type.EmptyTypes) != null)
                {
                    var nestObj = Activator.CreateInstance(propType);
                    SetDefaultValues(nestObj);
                    prop.SetValue(obj, nestObj);
                }
            }
        }
    }
}
