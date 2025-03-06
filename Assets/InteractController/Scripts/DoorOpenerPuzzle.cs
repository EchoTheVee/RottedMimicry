using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenerPuzzle : MonoBehaviour
{
    // Start is called before the first frame update
    public PuzzlePlusController ppc;
    public GameObject obstacle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ppc.isCompleted)
        {
            obstacle.SetActive(false);
        }
    }
}
