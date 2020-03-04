﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.Build.Utilities;

namespace Microsoft.Build.Tasks
{
    class SemaphoreCPUTask : Task
    {
        public override bool Execute()
        {
            Log.LogMessageFromText($"Got {BuildEngine7.RequestCores(3123890)} cores", Framework.MessageImportance.High);

            BuildEngine7.ReleaseCores(50);
            Log.LogMessageFromText("Released some number of cores", Framework.MessageImportance.High);

            Log.LogMessageFromText($"Got {BuildEngine7.RequestCores(10)} cores", Framework.MessageImportance.High);

            Log.LogMessageFromText($"Got {BuildEngine7.RequestCores(30)} cores", Framework.MessageImportance.High);

            BuildEngine7.ReleaseCores(2);
            Log.LogMessageFromText("Released some number of cores", Framework.MessageImportance.High);

            Log.LogMessageFromText($"Got {BuildEngine7.RequestCores(12)} cores", Framework.MessageImportance.High);

            return !Log.HasLoggedErrors;
        }


    }
}
