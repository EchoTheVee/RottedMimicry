using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractController : MonoBehaviour
{
    public GameObject interactIcon;
    public bool isInteractedWith;

    // Start is called before the first frame update
    void Start()
    {
        //interactIcon = GameObject.Find("InteractIcon");
    }

    // Update is called once per frame
    void Update()
    {
        if (interactIcon.activeInHierarchy && Input.GetKeyDown(KeyCode.E))
        {
            Interaction();
            isInteractedWith = true;
        }

       if (Input.GetKeyUp(KeyCode.E))
        {
            isInteractedWith = false;
        }
    }

    public void Interaction()
    {
        Debug.Log("YOU INTERACTED WITH ME!");
    }
}
