using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewItemIssue.Models;

public class ItemMock
{
    public List<Item> Items { get; set; } = new List<Item>();

    public ItemMock()
    {
        Init();
    }

    private void Init()
    {
        for (int i = 0; i < 200; i++)
        {
            var item = new Item
            {
                Id = i,
                Name = "Item " + $"{i}",
                CreateDate = DateTime.Now - TimeSpan.FromDays(i)
            };
            Items.Add(item);
        }
    }
}
