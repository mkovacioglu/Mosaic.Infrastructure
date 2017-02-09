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


using System.Net.NetworkInformation;

namespace VP.FF.PT.Common.Infrastructure
{
    public static class PingCheck
    {
        /// <summary>
        /// Checks whether a ping is successful or not.
        /// </summary>
        /// <param name="ipAddress">Target address.</param>
        /// <returns>Value indicating whether ping was successful.</returns>
        public static bool SynchrounouslyCheck(string ipAddress)
        {
            var pingSender = new Ping();
            const int timeout = 200;

            PingReply reply;
            try
            {
                reply = pingSender.Send(ipAddress, timeout);
            }
            catch (PingException)
            {
                return false;
            }

            if (reply.Status != IPStatus.Success)
            {
                return false;
            }

            return true;
        }
    }
}
