using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Linq;
using System;
using Unity.VisualScripting;

[System.Serializable]
public class InventorySystem
{
    [SerializeField] private List<InventorySlot> inventorySlots;
    [SerializeField] private int _gold;

    public int Gold => _gold;

    public List<InventorySlot> InvetnorySlots => inventorySlots;
    public int InventorySize => inventorySlots.Count;

    public UnityAction<InventorySlot> OnInventorySlotChanged;

    public InventorySystem(int size) // Constructor that sets the amount of slots.
    {
        _gold = 0;
        CreateInventory(size);
    }

    public InventorySystem(int size, int gold)
    {
        _gold = gold;
        CreateInventory(size);
    }

    private void CreateInventory(int size)
    {
        inventorySlots = new List<InventorySlot>(size);

        for (int i = 0; i < size; i++)
        {
            inventorySlots.Add(new InventorySlot());
        }
    }

    public bool AddToInventory(InventoryItemData itemToAdd, int amountToAdd)
    {
        if (ContainsItem(itemToAdd, out List<InventorySlot> invSlot)) // Check whether item exists in inventory.
        {
            foreach (var slot in invSlot)
            {
                if (slot.EnoughRoomLeftInStack(amountToAdd))
                {
                    slot.AddToStack(amountToAdd);
                    OnInventorySlotChanged?.Invoke(slot);
                    return true;
                }
            }

        }

        if (HasFreeSlot(out InventorySlot freeSlot)) // Gets the first available slot.
        {
            if (freeSlot.EnoughRoomLeftInStack(amountToAdd))
            {
                freeSlot.UpdateInventorySlot(itemToAdd, amountToAdd);
                OnInventorySlotChanged?.Invoke(freeSlot);
                return true;
            }
        }

        return false;
    }

    public bool ContainsItem(InventoryItemData ItemToAdd, out List<InventorySlot> invSlot) // Do any of our slots have the itme to add in item?
    {
        invSlot = InvetnorySlots.Where(i => i.ItemData == ItemToAdd).ToList(); // If they do, the get a list of all of them.
        return invSlot == null ? false : true; // If they do return true, if not return false.
    }

    public bool HasFreeSlot(out InventorySlot freeSlot)
    {
        freeSlot = InvetnorySlots.FirstOrDefault(i => i.ItemData == null); // Get the first free slot.
        return freeSlot == null ? false : true;
    }

    public bool CheckInventoryRemaining(Dictionary<InventoryItemData, int> shoppingCart)
    {
        var clonedSystem = new InventorySystem(this.InventorySize);

        for (int i = 0; i < InventorySize; i++)
        {
            clonedSystem.inventorySlots[i].AssignItem(this.InvetnorySlots[i].ItemData, this.InvetnorySlots[i].StackSize);
        }

        foreach (var kpv in shoppingCart)
        {
            for (int i = 0; i < kpv.Value; i++)
            {
                if (!clonedSystem.AddToInventory(kpv.Key, 1)) return false;
            }
        }

        return true;
    }

    internal void SpendGold(int basketTotal)
    {
        _gold -= basketTotal;
    }

    public Dictionary<InventoryItemData, int> GetAllItemsHeld()
    {
        var dictionaryItems = new Dictionary<InventoryItemData, int>();

        foreach (var item in inventorySlots)
        {
            if (item.ItemData == null) continue;

            if (!dictionaryItems.ContainsKey(item.ItemData)) dictionaryItems.Add(item.ItemData, item.StackSize);
            else dictionaryItems[item.ItemData] += item.StackSize;
        }

        return dictionaryItems;
    }

    public void GainGold(int price)
    {
        _gold += price;
    }

    public void RemoveItemsFromInventory(InventoryItemData data, int amount)
    {
        if (ContainsItem(data, out List<InventorySlot> invSlot))
        {
            foreach (var slot in invSlot)
            {
                var stackSize = slot.StackSize;

                if (stackSize > amount) slot.RemoveFromStack(amount);
                else
                {
                    slot.RemoveFromStack(amount);
                    amount -= stackSize;
                }

                OnInventorySlotChanged?.Invoke(slot);
            }
        }
    }
}
