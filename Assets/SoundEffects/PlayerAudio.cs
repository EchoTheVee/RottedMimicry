using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    public AudioClip walk;
    public AudioSource As;
    private float horizontalInput;
    public bool audioLength;

    // Start is called before the first frame update
    void Start()
    {
        As = GetComponent<AudioSource>();
        //HI = GetComponent<HorizontalInput>();
        audioLength = false;
    }

    // Update is called once per frame
    void Update()
    {
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
}
