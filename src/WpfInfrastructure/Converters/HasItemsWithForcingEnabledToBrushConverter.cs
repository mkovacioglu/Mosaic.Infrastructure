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
using System.Collections.Generic;
using System.Linq;
using System.Windows.Data;
using System.Windows.Media;
using VP.FF.PT.Common.WpfInfrastructure.Screens.ViewModels;

namespace VP.FF.PT.Common.WpfInfrastructure.Converters
{
    public class HasItemsWithForcingEnabledToBrushConverter : IValueConverter
    {
        public Brush TrueValue { get; set; }
        public Brush FalseValue { get; set; }

        public HasItemsWithForcingEnabledToBrushConverter()
        {
            TrueValue = null;
            FalseValue = null;
        }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var forcingKeyValueUnitViewModels = value as IEnumerable<ForcingKeyValueUnitViewModel>;
            return forcingKeyValueUnitViewModels.Any(forcingKeyValueUnitViewModel => forcingKeyValueUnitViewModel.IsEnabled) ? TrueValue : FalseValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
