﻿namespace FullContactDotNet.Person
{
    public class Demographics
    {
        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        public string Age { get; set; }

        /// <summary>
        /// Gets or sets the age range.
        /// </summary>
        /// <value>
        /// The age range.
        /// </value>
        public string AgeRange { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the location deduced.
        /// </summary>
        /// <value>
        /// The location deduced.
        /// </value>
        public LocationDeduced LocationDeduced { get; set; }

        /// <summary>
        /// Gets or sets the location general.
        /// </summary>
        /// <value>
        /// The location general.
        /// </value>
        public string LocationGeneral { get; set; }
    }
}
