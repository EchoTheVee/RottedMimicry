using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractController : MonoBehaviour
{
    public GameObject interactIcon;
    public bool isInteractedWith;
    public bool pIS;

    // Start is called before the first frame update
    void Start()
    {
        //interactIcon = GameObject.Find("InteractIcon");
    }

    // Update is called once per frame
    void Update()
    {

        if (interactIcon.activeInHierarchy && Input.GetKeyDown(KeyCode.E) && !isInteractedWith && pIS)
        {
            Interaction();
            isInteractedWith = true;
            pIS = false;
            StartCoroutine(InteractionCooldown());
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Debug.Log($"I've been touched by {collision.gameObject.name}");
        pIS = true;
    }



    public void Interaction()
    {
        Debug.Log($"YOU INTERACTED WITH {gameObject.name}");
    }

    IEnumerator InteractionCooldown()
    {
        yield return new WaitForSeconds(2);
        isInteractedWith = false;
    }
}
