using System;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance { get; private set; }

    public event Action OnInventoryChanged;

    private Dictionary<ItemData, int> items = new Dictionary<ItemData, int>();

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public bool AddItem(ItemData item, int amount = 1)
    {
        if (item == null || amount <= 0) return false;

        if (items.ContainsKey(item))
        {
            if (item.isStackable && items[item] + amount <= item.maxStackSize)
            {
                items[item] += amount;
            }
            else if (!item.isStackable)
            {
                return false;
            }
        }
        else
        {
            items[item] = amount;
        }

        OnInventoryChanged?.Invoke();
        return true;
    }

    public bool RemoveItem(ItemData item, int amount = 1)
    {
        if (!items.ContainsKey(item) || items[item] < amount) return false;

        items[item] -= amount;
        if (items[item] <= 0) items.Remove(item);

        OnInventoryChanged?.Invoke();
        return true;
    }

    public int GetItemCount(ItemData item)
    {
        return items.TryGetValue(item, out int count) ? count : 0;
    }
}
