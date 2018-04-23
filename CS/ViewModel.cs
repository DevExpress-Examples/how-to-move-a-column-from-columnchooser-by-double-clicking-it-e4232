using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DXGridSample
{
    public class MainViewModel {
        public virtual ObservableCollection<Item> Items { get; set; }
        public MainViewModel() {
            Items = new ObservableCollection<Item>();
            for (int i = 0; i < 100; i++)
                Items.Add(new Item { Id = i, Name = "Name" + i });
        }
    }
    public class Item {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
