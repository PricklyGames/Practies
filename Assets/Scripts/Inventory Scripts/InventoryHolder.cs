using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class InventoryHolder : MonoBehaviour
{
    [SerializeField] private int invetnorySize;
    [SerializeField] protected InventorySystem primaryInventorySystem;
    [SerializeField] protected int _gold;

    public InventorySystem PrimaryInventorySystem => primaryInventorySystem;

    public static UnityAction<InventorySystem> OnDynamicinvenotryDisplayRequested;

    protected virtual void Awake()
    {
        primaryInventorySystem = new InventorySystem(invetnorySize, _gold);
    }
}
