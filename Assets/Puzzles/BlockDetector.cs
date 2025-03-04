using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDetector : MonoBehaviour
{
    public bool isActive;
    public GameObject up;
    public GameObject down;
    public GameObject left;
    public GameObject right;

    public BlockDetector upBD;
    public BlockDetector downBD;
    public BlockDetector leftBD;
    public BlockDetector rightBD;

    public SpriteRenderer sr;
    public Material off;
    public Material on;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        if (up != null)
        {
        upBD = up.GetComponent<BlockDetector>();
        }

        if (down != null)
        {
        downBD = down.GetComponent<BlockDetector>();
        }

        if (left != null)
        {
        leftBD = left.GetComponent<BlockDetector>();
        }

        if (right != null)
        {
        rightBD = right.GetComponent<BlockDetector>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            sr.material = on;
        }

        if (!isActive)
        {
            sr.material = off;
        }
    }

    private void OnMouseDown()
    {
        isActive = !isActive;
        if (upBD != null)
        {
        upBD.isActive = !upBD.isActive;
        }

        if (downBD != null)
        {
        downBD.isActive = !downBD.isActive;
        }

        if (leftBD != null)
        {
        leftBD.isActive = !leftBD.isActive;
        }

        if (rightBD != null)
        {
        rightBD.isActive = !rightBD.isActive;
        }
    }

}
