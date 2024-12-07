using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<string> items = new List<string>(); // List of items in inventory

    // Add an item to the inventory
    public void AddItem(string item)
    {
        items.Add(item);
        Debug.Log(item + " added to inventory.");
    }

    // Show all collected items
    public void ShowInventory()
    {
        Debug.Log("Inventory: " + string.Join(", ", items)); // Display items in console
    }
}
