using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteractController : MonoBehaviour
{
    public bool iIS;
    public InventoryHolder ih;
    public InteractController ic;
    public GameObject interactIcon;
    public int itemNumber;
    
    //public string itemName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((interactIcon.activeInHierarchy) && ic.pIS && iIS && Input.GetKeyDown(KeyCode.E) && ic.isItem)
        {
            //ih.itemName = itemName;
            ih.itemGrabbed = itemNumber;
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ic.isItem = true;
            iIS = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ic.isItem = false;
            iIS = false;
        }
    }
}
