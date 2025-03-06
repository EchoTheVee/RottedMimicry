using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIInteractController : MonoBehaviour
{
    public InteractController iC;
    public GameObject GUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (iC.isGUI && iC.interactIcon.activeInHierarchy && Input.GetKeyDown(KeyCode.E))
        {
            GUI.SetActive(true);
        }

        if (!iC.isGUI && !iC.interactIcon.activeInHierarchy)
        {
            GUI.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            iC.isGUI = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            iC.isGUI = false;
        }
    }
}
