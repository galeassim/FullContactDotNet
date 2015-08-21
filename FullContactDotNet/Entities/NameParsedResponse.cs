﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContactDotNet.Entities
{
    public class NameParsedResponse : FullContactResponse
    {
        /// <summary>
        /// Gets or sets the name of the ambiguous.
        /// </summary>
        /// <value>
        /// The name of the ambiguous.
        /// </value>
        public string AmbiguousName { get; set; }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public NameParsed Result { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        /// <value>
        /// The region.
        /// </value>
        public string Region { get; set; }
    }
}
