using System.Linq.Expressions;
using System.Reflection;

namespace DesignPatterns.Application.Creational.Builder.AutoFixtureBuilder
{
    public class FixtureBuilder<TResult>
      where TResult : new()
    {
        private readonly Dictionary<string, object> _propertyValues = new();

        public FixtureBuilder<TResult> With<TProperty>(Expression<Func<TResult, TProperty>> propSelector, TProperty value)
        {
            var propertyName = GetPropertyName(propSelector);

            _propertyValues[propertyName] = value;

            return this;
        }

        public FixtureBuilder<TResult> Without<TProperty>(Expression<Func<TResult, TProperty>> selector)
        {
            var propertyName = GetPropertyName(selector);
            _propertyValues[propertyName] = null;
            return this;
        }

        public TResult Create()
        {
            var instance = new TResult();
            Type type = typeof(TResult);

            foreach (var propValue in _propertyValues)
            {
                var prop = type.GetProperty(propValue.Key);
                prop.SetValue(instance, propValue.Value);
            }

            return instance;
        }

        private string GetPropertyName<TProperty>(Expression<Func<TResult, TProperty>> propSelector)
          => (propSelector.Body as MemberExpression).Member.Name;
    }
}
