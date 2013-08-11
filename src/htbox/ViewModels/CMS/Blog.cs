﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using N2;
using N2.Definitions;
using N2.Integrity;

namespace htbox.ViewModels.CMS {
    [PageDefinition("Blog")]
    [RestrictChildren(typeof(BlogPost))]
    [SortChildren(SortBy.Expression, SortExpression = "Published DESC")]
    public class Blog : CMSPage {
    }
}