using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    public AudioClip walk;
    public AudioSource As;
    public AudioClip interactable;
    public AudioClip door;
    public AudioClip inventory;
    private float horizontalInput;
    public bool audioLength;
    public GameObject iR;
    public DoorHolderInteractable doorIr;
    public GameObject interactIcon;

    // Start is called before the first frame update
    void Start()
    {
        As = GetComponent<AudioSource>();
        doorIr = GetComponent<DoorHolderInteractable>();
        audioLength = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (interactIcon.activeInHierarchy && Input.GetKeyDown(KeyCode.E))
        {
            As.PlayOneShot(interactable);
        }
       // else ()

        if (interactIcon.activeInHierarchy && Input.GetKeyDown(KeyCode.Tab))
        {
            As.PlayOneShot(inventory);
        }

        horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput >= 0.1 && audioLength == false)
        {
            As.PlayOneShot(walk);
            audioLength = true;
        }
        else if (horizontalInput <= -0.1 && audioLength == false)
        {
            As.PlayOneShot(walk);
            audioLength = true;
        }

        if (horizontalInput == 0)
        {
            audioLength = false;
        }



    }

    public void PlayDoorSound()
    {
        As.PlayOneShot(door);
    }
}
