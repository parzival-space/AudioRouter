using CommandLine;

namespace AudioRouter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Commands.Formats.List, Commands.Formats.Mirror>(args)
                .MapResult(
                    (Commands.Formats.List options) => Commands.Actions.List.Run(options),
                    (Commands.Formats.Mirror options) => Commands.Actions.Mirror.Run(options),
                    error => 1
                );

            #if DEBUG
                new System.Threading.ManualResetEvent(false).WaitOne();
            #endif
        }
    }
}
