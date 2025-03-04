using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePlusController : MonoBehaviour
{
    public bool isCompleted;

    public BlockDetector block1;
    public BlockDetector block2;
    public BlockDetector block3;
    public BlockDetector block4;

    public BlockDetector block5;
    public BlockDetector block6;
    public BlockDetector block7;
    public BlockDetector block8;

    public BlockDetector block9;
    public BlockDetector block10;
    public BlockDetector block11;
    public BlockDetector block12;

    public BlockDetector block13;
    public BlockDetector block14;
    public BlockDetector block15;
    public BlockDetector block16;

    //==========================\\
    //  1  2  3  4
    //  5  6  7  8
    //  9 10 11 12
    // 13 14 15 16



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (block1.isActive && block2.isActive && block3.isActive && block4.isActive
            &&
            block5.isActive && block6.isActive && block7.isActive && block8.isActive
            &&
            block9.isActive && block10.isActive && block11.isActive && block12.isActive
            &&
            block13.isActive && block14.isActive && block15.isActive && block16.isActive)
        {
            isCompleted = true;
        }
    }
}
