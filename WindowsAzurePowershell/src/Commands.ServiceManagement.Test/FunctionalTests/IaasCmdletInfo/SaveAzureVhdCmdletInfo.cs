﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Management.ServiceManagement.Test.FunctionalTests.IaasCmdletInfo
{
    using System;
    using System.IO;
    using Microsoft.WindowsAzure.Management.ServiceManagement.Test.FunctionalTests.PowershellCore;

    public class SaveAzureVhdCmdletInfo : CmdletsInfo
    {
        public SaveAzureVhdCmdletInfo(Uri source, FileInfo localFilePath, int? numThreads, string storageKey, bool overwrite)
        {
            cmdletName = Utilities.SaveAzureVhdCmdletName;
            cmdletParams.Add(new CmdletParam("Source", source));
            cmdletParams.Add(new CmdletParam("LocalFilePath", localFilePath));

            if (numThreads != null)
            {
                cmdletParams.Add(new CmdletParam("NumberOfThreads", numThreads));
            }

            if (!String.IsNullOrWhiteSpace(storageKey))
            {
                cmdletParams.Add(new CmdletParam("StorageKey", storageKey));                
            }            
            
            if (overwrite)
            {
                cmdletParams.Add(new CmdletParam("OverWrite"));
            }
        }        
    }
}