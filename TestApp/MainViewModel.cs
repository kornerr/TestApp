
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

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
    }
}

} // namespace TestApp.

