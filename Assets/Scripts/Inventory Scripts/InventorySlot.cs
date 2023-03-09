using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

[System.Serializable]
public class InventorySlot : ItemSlot
{
    public InventorySlot(InventoryItemData source, int amount) // Constructor to make a occupied inventory slot.
    {
        itemData = source;
        stackSize = amount;
    }
    public InventorySlot() // Constructor to make an empty inventory slot.
    {
        ClearSlot();
    }

    public void UpdateInventorySlot(InventoryItemData data, int amount) // Updates slot directly.
    {
        itemData = data;
        stackSize = amount;

    }

    public bool RoomLeftInStack(int amountToAdd, out int amountRemaining) // Would the be enough room in the stack for the amount we're trying to add.
    {
        amountRemaining = ItemData.MaxStackSize - stackSize;

        return EnoughRoomLeftInStack(amountToAdd);
    }

    public bool EnoughRoomLeftInStack(int amountToAdd)
    {
        if (ItemData == null || ItemData != null && stackSize + amountToAdd <= itemData.MaxStackSize) return true;
        else return false;
    }

    public bool SplitStack(out InventorySlot splitStack)
    {
        if (stackSize <= 1) // Is there enough to actually split? If not return false.
        {
            splitStack = null;
            return false;
        }

        int halfStack = Mathf.RoundToInt(stackSize / 2); // Get half the stack.
        RemoveFromStack(halfStack);

        splitStack = new InventorySlot(itemData, halfStack); // Creates a copy of this slot with half the stack size.

        return true;
    }
}
