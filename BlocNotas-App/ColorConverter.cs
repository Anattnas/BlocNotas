﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace BlocNotas
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return Brushes.Transparent;

            switch (value.ToString())
            {
                case "Rojo":
                    return Brushes.OrangeRed;
                case "Azul":
                    return Brushes.DodgerBlue;
                case "Amarillo":
                    return Brushes.Yellow;
                case "Verde":
                    return Brushes.LimeGreen;
                default:
                    return Brushes.Transparent; // Si el color no es reconocido, se usa transparente
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}