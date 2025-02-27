using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIInventory : MonoBehaviour
{
    public InventoryHolder ih;
    public GameObject inventory;
    private bool inventoryIsOpen = false;
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            inventoryIsOpen = true;
        }


        if (Input.GetKeyUp(KeyCode.Tab))
        {
            inventoryIsOpen = false;
        }
        
        if (inventoryIsOpen)
        {
            inventory.SetActive(true);
        }

        if (!inventoryIsOpen)
        {
            inventory.SetActive(false);
        }

        if (ih.hasItem1 && inventoryIsOpen)
        {
            item1.SetActive(inventoryIsOpen);
        }
        if (ih.hasItem2 && inventoryIsOpen)
        {
            item2.SetActive(inventoryIsOpen);
        }
        if (ih.hasItem3 && inventoryIsOpen)
        {
            item3.SetActive(inventoryIsOpen);
        }
        if (ih.hasItem4 && inventoryIsOpen)
        {
            item4.SetActive(inventoryIsOpen);
        }
    }
}
