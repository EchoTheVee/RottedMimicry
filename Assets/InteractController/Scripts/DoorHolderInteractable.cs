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

    //Xander touched it.
    public PlayerAudio playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        pc = GameObject.Find("Player").GetComponent<PlayerController>();
        //iC = GetComponent<InteractController>();

        // xanders scandalaus touch
        playerAudio.GetComponent<PlayerAudio>();
    }

    // Update is called once per frame
    void Update()
    {
        //hasTeleported2 = !hasTeleported1;
        //hasTeleported1 = !hasTeleported2;

        if (iC.isInteractedWith  && Input.GetKeyDown(KeyCode.E) && pc.canTeleport && iC.isDoorway)
        {
            Debug.Log($"Teleporting to {teleportPosition.name}");
            //DoorTransition();
            player.transform.position = teleportPosition.transform.position;

            //omg he touched the butt
            playerAudio.PlayDoorSound();

            //hasTeleported1 = true;
            //StartCoroutine(TransitionWait());
            pc.canTeleport = false;
            StartCoroutine(TeleportCooldown());
        }

        if (iC2.isInteractedWith  && Input.GetKeyDown(KeyCode.E) && pc.canTeleport && iC2.isDoorway)
        {
            Debug.Log($"Teleporting to {teleportPosition2.name}");
            //DoorTransition();
            player.transform.position = teleportPosition2.transform.position;

            // omg he touched the booty again
            playerAudio.PlayDoorSound();

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
