
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace TestApp
{

public class MainViewModel
{
    public CustomObservableCollection<Item> Items { get; set; }

    public ICommand Change { get; set; }

    public MainViewModel()
    {
        Items = new CustomObservableCollection<Item>();
        // Research collection change events.
        Items.CollectionChanged += CollectionDidChange;

        
        // Stub data.
        Items.Add(new Item("key1", "val1"));
        Items.Add(new Item("key2", "val2"));

        // Change command.
        Change = new Command(
            (nothing) =>
            {
                Debug.WriteLine("Change command");
                // Change item.
                var item = Items[1];
                Debug.WriteLine("BEFORE item: {0}/{1}", item.Key, item.Value);
                item.Key   = "keyNew";
                item.Value = "valNew";
                Debug.WriteLine("AFTER item: {0}/{1}", item.Key, item.Value);
                // Report.
                Items.ReportItemChange(item);
            });
    }
    public void CollectionDidChange(object sender,
                                    NotifyCollectionChangedEventArgs e)
    {
        string msg =
@"Collection did change. Sender: {0}
Action:           {1}
NewItems:         {2}
NewStartingIndex: {3}
OldItems:         {4}
OldStartingIndex: {5}";
        Debug.WriteLine(msg,
                        sender,
                        e.Action,
                        string.Join(", ", e.NewItems),
                        e.NewStartingIndex,
                        string.Join(", ", e.OldItems),
                        e.OldStartingIndex);
        foreach (var item in e.NewItems)
            Debug.WriteLine("NewItem: {0}", item);
    }
}

} // namespace TestApp.

