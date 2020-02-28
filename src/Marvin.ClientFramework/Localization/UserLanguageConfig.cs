﻿using System.Runtime.Serialization;
using Marvin.Configuration;

namespace Marvin.ClientFramework.Localization
{
    /// <summary>
    /// Configuration class for the setted language
    /// </summary>
    [DataContract]
    public class UserLanguageConfig : ConfigBase
    {
        /// <summary>
        /// Gets or sets the first language.
        /// </summary>
        [DataMember]
        public string Culture { get; set; }
    }

}