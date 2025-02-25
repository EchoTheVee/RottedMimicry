using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHolderInteractable : MonoBehaviour
{
    public InteractController iC;
    public InteractController iC2;
    private GameObject player;
    public PlayerController pc;
    public GameObject teleportPosition;
    public GameObject teleportPosition2;
    public bool hasTeleported1;
    public bool hasTeleported2;
    public int timeToWait;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        pc = GameObject.Find("Player").GetComponent<PlayerController>();
        //iC = GetComponent<InteractController>();
    }

    // Update is called once per frame
    void Update()
    {
        //hasTeleported2 = !hasTeleported1;
        //hasTeleported1 = !hasTeleported2;

        if (iC.isInteractedWith  && Input.GetKeyDown(KeyCode.E) && pc.canTeleport)
        {
            Debug.Log($"Teleporting to {teleportPosition.name}");
            //DoorTransition();
            player.transform.position = teleportPosition.transform.position;
            //hasTeleported1 = true;
            //StartCoroutine(TransitionWait());
            pc.canTeleport = false;
            StartCoroutine(TeleportCooldown());
        }

        if (iC2.isInteractedWith  && Input.GetKeyDown(KeyCode.E) && pc.canTeleport)
        {
            Debug.Log($"Teleporting to {teleportPosition2.name}");
            //DoorTransition();
            player.transform.position = teleportPosition2.transform.position;
            //hasTeleported2 = true;
            //StartCoroutine(TransitionWait2());
            pc.canTeleport = false;
            StartCoroutine(TeleportCooldown());
        }

        
    }

    IEnumerator TeleportCooldown()
    {
        yield return new WaitForSeconds(3);
        pc.canTeleport = true;
    }
}
