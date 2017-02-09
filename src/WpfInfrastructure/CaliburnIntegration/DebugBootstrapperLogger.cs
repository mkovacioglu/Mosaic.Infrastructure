/* Copyright 2017 Cimpress

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License. */


using System;
using System.Diagnostics;
using Caliburn.Micro;

namespace VP.FF.PT.Common.WpfInfrastructure.CaliburnIntegration
{
    public class DebugBootstrapperLogger : ILog
    {
        private string CreateLogMessage(string format, params object[] args)
        {
            return string.Format("[{0}] {1}", 
                                 DateTime.Now.ToString("o"),
                                 string.Format(format, args));
        }

        public void Error(Exception exception)
        {
            Debug.WriteLine(CreateLogMessage(exception.ToString()), "ERROR BOOTSTRAPPER");
        }

        public void Info(string format, params object[] args)
        {
            Debug.WriteLine(CreateLogMessage(format, args), "INFO BOOTSTRAPPER");
        }

        public void Warn(string format, params object[] args)
        {
            Debug.WriteLine(CreateLogMessage(format, args), "WARN BOOTSTRAPPER");
        }
    }
}
