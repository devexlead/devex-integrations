﻿using System;

namespace Integrations.Confluence.Model
{
    public class ConfluencePageLastUpdated
    {
        public ConfluencePageUpdatedBy By { get; set; }
        public DateTime When { get; set; }
    }
}
