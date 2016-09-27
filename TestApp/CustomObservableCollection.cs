
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace TestApp
{

public class CustomObservableCollection<T> : ObservableCollection<T>
{
    public CustomObservableCollection() { }
    public CustomObservableCollection(IEnumerable<T> items) : this()
    {
        foreach (var item in items)
            this.Add(item);
    }
    public void ReportItemChange(T item)
    {
        NotifyCollectionChangedEventArgs args =
            new NotifyCollectionChangedEventArgs(
                NotifyCollectionChangedAction.Replace,
                item,
                item,
                IndexOf(item));
        OnCollectionChanged(args);
    }
}

} // namespace TestApp.

