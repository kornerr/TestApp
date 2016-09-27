
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;

namespace TestApp
{

public class MainViewModel
{
    public ObservableCollection<Item> Items { get; set; }

    public MainViewModel()
    {
        Items = new ObservableCollection<Item>();
        
        // Stub data.
        Items.Add(new Item("key1", "val1"));
        Items.Add(new Item("key2", "val2"));
        /*
        // Change item.
        var item = Items[1];
        Debug.WriteLine("BEFORE item: {0}/{1}", item.Key, item.Value);
        item.Key   = "keyNew";
        item.Value = "valNew";
        Debug.WriteLine("AFTER item: {0}/{1}", item.Key, item.Value);
        */
    }
}

} // namespace TestApp.

