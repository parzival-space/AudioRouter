using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioRouter.Commands.Formats
{
    [Verb("mirror", HelpText = "Copy an audio loopback stream from one audio device to another.")]
    internal class Mirror
    {
        [Option('s', "source")]
        public string Source { get; set; }

        [Option('d', "destination", Required = true)]
        public string Destination { get; set; }

        [Option('l', "latency", Default = 10)]
        public int Latency { get; set; }
    }
}
