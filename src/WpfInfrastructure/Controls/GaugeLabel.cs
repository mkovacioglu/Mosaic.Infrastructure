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


using System.Windows;
using System.Windows.Controls;

namespace VP.FF.PT.Common.WpfInfrastructure.Controls
{
    /// <summary>
    /// The <see cref="GaugeLabel"/> is a progress bar 
    /// usable for displaying the gauge label of either shirt- or paperstream.
    /// </summary>
    public class GaugeLabel : ProgressBar
    {
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
            "Icon", typeof(Style), typeof(GaugeLabel), new PropertyMetadata(default(Style)));

        public Style Icon
        {
            get { return (Style)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
    }
}
