using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float JumpChanceCountdown;
    public int ChanceToJump;
    public Rigidbody2D PlayerRb;
    public int Speed;
    public float JumpChanceTimer;
    public bool CanJump;
    // Start is called before the first frame update
    void Start()
    {
        JumpChanceCountdown = JumpChanceTimer;
        ChanceToJump = 3;
        CanJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(Speed, 0, 0) * Time.deltaTime;
        JumpChance();
    }

    void JumpChance()
    {
        JumpChanceCountdown = JumpChanceCountdown -= Time.deltaTime;

        if (JumpChanceCountdown <= 0f)
        {
            JumpChanceCountdown = JumpChanceTimer;
            ChanceToJump = Random.Range(0, 3);
        }

        if (ChanceToJump == 0 && CanJump)
        {
            Jump();
            ChanceToJump = 3;
        }

        else
        {
            return;
        }
    }
    public void Jump()
    {
        PlayerRb.AddForce(new Vector2(1, 7), ForceMode2D.Impulse);
    }

}
