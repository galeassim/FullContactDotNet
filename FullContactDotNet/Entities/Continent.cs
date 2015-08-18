﻿namespace FullContactDotNet.Entities
{
    public class Continent
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Continent"/> is deduced.
        /// </summary>
        /// <value>
        ///   <c>true</c> if deduced; otherwise, <c>false</c>.
        /// </value>
        public bool Deduced { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
    }
}