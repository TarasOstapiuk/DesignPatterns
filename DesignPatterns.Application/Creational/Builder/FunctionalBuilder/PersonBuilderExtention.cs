namespace DesignPatterns.Application.Creational.Builder.FunctionalBuilder
{
    public static class PersonBuilderExtention
    {
        public static PersonBuilder WorksAsA(this PersonBuilder builder, string position)
        {
            builder.Do(p => { p.Position = position; });
            return builder;
        }
    }
}
