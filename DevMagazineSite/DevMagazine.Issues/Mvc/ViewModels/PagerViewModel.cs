﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DevMagazine.Issues.Mvc.ViewModels
{
    public class PagerViewModel
    {
        /// <summary>
        /// Gets or sets the current page.
        /// </summary>
        /// <value>The current page.</value>
        public int CurrentPage { get; set; }

        /// <summary>
        /// Gets or sets the total pages count.
        /// </summary>
        /// <value>The total pages count.</value>
        public int? TotalPagesCount { get; set; }

        /// <summary>
        /// Gets or sets the issues.
        /// </summary>
        /// <value>The issues.</value>
        public IEnumerable<IssueViewModel> Issues { get; set; }
    }
}
