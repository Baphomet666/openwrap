﻿using System;
using System.Collections.Generic;

namespace OpenWrap.Dependencies
{
    public class DescriptionParser : AbstractDescriptorParser
    {
        public DescriptionParser() : base("description")
        {
        }

        protected override void ParseContent(string content, PackageDescriptor descriptor)
        {
            descriptor.Description = content.Trim();
        }
        // TODO: Provide pretty-formatting on the write-side with collapsing beyond 120 chars
        protected override IEnumerable<string> WriteContent(PackageDescriptor descriptor)
        {
            if (!string.IsNullOrEmpty(descriptor.Description))
                yield return descriptor.Description;
        }
    }
}