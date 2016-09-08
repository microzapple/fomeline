using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FomeLine.Helpers
{
    public class Group<TKey, TItem> : ObservableCollection<TItem>
    {
        public TKey Key { get; private set; }

        public Group(TKey key, IEnumerable<TItem> items)
        {
            Key = key;
            foreach (var item in items) Items.Add(item);
        }
    }
}