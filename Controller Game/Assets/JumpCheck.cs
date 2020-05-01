using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCheck : MonoBehaviour
{
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //checks if the player is on the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("jump");
            Player.GetComponent<PlayerController>().Jump();
        }
    }
}
