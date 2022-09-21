﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Azure.Template
{
    public partial class AzureModel
    {
        // This should be internal so users can't access it publicly
        public AzureModel()
        {
        }

        public string RequiredString { get; internal set; }

        public int RequiredInt { get; internal set; }

        public long RequiredLong { get; internal set; }

        public float RequiredFloat { get; internal set; }

        public double RequiredDouble { get; internal set; }

        public bool RequiredBoolean { get; internal set; }

        public DateTimeOffset RequiredDateTime { get; internal set; }

        public TimeSpan RequiredDuration { get; internal set; }

        public IList<string> RequiredStringArray { get; internal set; }

        public IList<int> RequiredIntArray { get; internal set; }

        public IList<ChildModel> RequiredChildModelArray { get; internal set; }

        //public Model ModelProperty { get; internal set; }
    }
}
