using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryHolder : MonoBehaviour
{
    public int itemGrabbed;
    //public string itemName;
    public bool hasItem1;
    public bool hasItem2;
    public bool hasItem3;
    public bool hasItem4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (itemGrabbed == 1)
        {
            hasItem1 = true;
        }

        if (itemGrabbed == 2)
        {
            hasItem2 = true;
        }

        if (itemGrabbed == 3)
        {
            hasItem3 = true;
        }

        if (itemGrabbed == 4)
        {
            hasItem4 = true;
        }
    }
}
