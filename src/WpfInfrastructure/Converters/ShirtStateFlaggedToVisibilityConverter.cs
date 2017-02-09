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
using System.Windows;
using System.Windows.Data;
using VP.FF.PT.Common.WpfInfrastructure.Screens.Model;

namespace VP.FF.PT.Common.WpfInfrastructure.Converters
{
    public class ShirtStateFlaggedToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            ShirtState shirtState = (ShirtState) value;

            if (parameter.ToString().Equals("Collapsed"))
            {
                if (shirtState.Equals(ShirtState.Flagged))
                {
                    return Visibility.Collapsed;
                }

                return Visibility.Visible;
            }

            if (parameter.ToString().Equals("Visible"))
            {
                if (shirtState.Equals(ShirtState.Flagged))
                {
                    return Visibility.Visible;
                }

                return Visibility.Collapsed;
            }

            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
