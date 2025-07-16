using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemController : MonoBehaviour
{
    public Item item;
    public Button RemoveButton;


    public void RemoveItem()
    {
        InventoryManager.Instance.Remove(item);

        Destroy(gameObject);

    }
    public void AddItem(Item newItem)
    {
        item = newItem;
    }

    public void UseItem()
    {
        switch (item.itemType)
        {
            case Item.ItemType.Potion:
                HealthforPlayer.Instance.increaseHealth(this.item.value);
                RemoveItem();
                break;



            case Item.ItemType.Book:
                RemoveItem();
                break;
            case Item.ItemType.Brush:
                RemoveItem();
                break;
            case Item.ItemType.Laptop:
                RemoveItem();
                break;
            case Item.ItemType.Plate:
                RemoveItem();
                break;
        }
    }
}