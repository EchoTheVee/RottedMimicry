using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbominationController : MonoBehaviour
{
    public Vector3 playerPOS;
    public GameObject player;
    public Rigidbody2D rb;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPOS = (player.transform.position - transform.position).normalized;
        rb.AddForce(playerPOS * moveSpeed);
    }
}
