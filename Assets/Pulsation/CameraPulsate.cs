using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPulsate : MonoBehaviour
{
    public Camera main;
    void Update()
    {
        main.fieldOfView = 50f + Mathf.PingPong(Time.time, 3f);
    }
}
