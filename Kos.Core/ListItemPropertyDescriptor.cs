using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kos.Core;

/// <summary>
/// リストアイテムのDescriptor
/// </summary>
/// <typeparam name="T"></typeparam>
public class ListItemPropertyDescriptor<T> : PropertyDescriptor
{
    private readonly T _item;
    private readonly int _index;

    public ListItemPropertyDescriptor(T item, int index) : base($"{index,5}", null)
    {
        _item = item;
        _index = index;
    }

    public override Type ComponentType => typeof(List<T>);
    public override bool IsReadOnly => false;
    public override Type PropertyType => typeof(T);
    public override object? GetValue(object? component) => _item;
    public override void SetValue(object? component, object? value) => throw new NotImplementedException();
    public override bool CanResetValue(object component) => false;
    public override void ResetValue(object component)
    {
    }
    public override bool ShouldSerializeValue(object component) => true;
}
