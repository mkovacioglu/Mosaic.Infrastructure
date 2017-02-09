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


namespace VP.FF.PT.Common.WpfInfrastructure.Screens.Model
{
    /// <summary>
    /// The ControllerState specifies the state of the controller.
    /// </summary>
    public enum ControllerState
    {
        /// <summary>
        /// The controller is in a normal state.
        /// </summary>
        Normal,

        /// <summary>
        /// The controller is in a warning state.
        /// </summary>
        Warning,

        /// <summary>
        /// The controller is in an error state.
        /// </summary>
        Error,
    }
}
