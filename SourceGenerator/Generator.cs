using Microsoft.CodeAnalysis;

namespace SourceGenerator
{
    [Generator]
    public class Generator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
        }

        public void Execute(GeneratorExecutionContext context)
        {
            var source = @"namespace MySG
{
    public static class Say
    {
        public static string Hello() => ""Hello"";
    }
}";

            if (source != null)
            {
                context.AddSource("generated.cs", source);
            }
        }
    }
}
