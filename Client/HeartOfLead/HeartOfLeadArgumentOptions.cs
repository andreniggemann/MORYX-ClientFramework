﻿using CommandLine;
using Marvin.ClientFramework.Kernel;

namespace Marvin.ClientFramework.HeartOfLead
{
    /// <summary>
    /// Class for the command line parameters.
    /// In this class all custom command line parameters are defined.
    /// </summary>
    public class HeartOfLeadArgumentOptions : CommandLineArgumentOptionsBase
    {
        /// <summary>
        /// Gets or sets a value indicating whether [start configurator].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [start configurator]; otherwise, <c>false</c>.
        /// </value>
        [Option('v', "configurator", HelpText = "Starts the configuration run mode.")]
        public bool StartConfigurator { get; set; }
    }
}