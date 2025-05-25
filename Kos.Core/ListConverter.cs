using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kos.Core;

/// <summary>
/// List&ltT&gtをPropertyGridで展開させるConverter
/// </summary>

public class ListConverter<T> : TypeConverter
{
    public override bool GetPropertiesSupported(ITypeDescriptorContext? context)
    {
        return true;
    }

    public override PropertyDescriptorCollection?
        GetProperties(ITypeDescriptorContext? context, object value, Attribute[]? attributes)
    {
        if (value is not IReadOnlyList<T> list) {
            return null;

        }
        PropertyDescriptor[] properties = new PropertyDescriptor[list.Count];

        for (int i = 0; i < list.Count; i++) {
            properties[i] = new ListItemPropertyDescriptor<T>(list[i], i);
        }

        return new PropertyDescriptorCollection(
            [.. properties.OrderBy(static p => int.Parse(p.Name))]
        );
    }

    public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
    {
        IReadOnlyList<T>? list = value as IReadOnlyList<T>;

        return $"(Collection Count={list?.Count})";
    }
}
