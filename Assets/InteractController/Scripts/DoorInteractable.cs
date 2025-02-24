using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractable : MonoBehaviour
{
    public InteractController iC;
    private GameObject player;
    public GameObject teleportPosition;
    public bool hasTeleported;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        iC = GetComponent<InteractController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (iC.isInteractedWith && !hasTeleported)
        {
            Debug.Log($"Teleporting to {teleportPosition.name}");
            DoorTransition();
            hasTeleported = true;
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            hasTeleported = false;
        }
    }

    public void DoorTransition()
    {
        player.transform.position = teleportPosition.transform.position;
    }
}
