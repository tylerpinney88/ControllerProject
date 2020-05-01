using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    float JumpChanceCountdown;
    public int ChanceToJump;
    public Rigidbody2D PlayerRb;
    public int Speed;
    public float JumpChanceTimer;
    public bool CanJump;
    public int Health;
    public int Coins;
    public int Lives;
    public Text livesText;
    public Text coinText;
    public Text LevelsComp;
    public int levelsComplete;
    public GameObject GameCan;
    public GameObject DeathCan;
    // Start is called before the first frame update
    void Start()
    {
        JumpChanceCountdown = JumpChanceTimer;
        ChanceToJump = 3;
        CanJump = true;
        Health = 5;
        Lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //just simple movement to make the player move across the screen at a steady pace
        //will also speed up the player as more and more levels are completed
        Speed = 1 + levelsComplete;
        transform.position = transform.position + new Vector3(Speed, 0, 0) * Time.deltaTime;
        JumpChance();
        HealthCheck();
        CoinCheck();
        TextUpdate();
        LivesCheck();
    }

    void JumpChance()
    {
        //generates a random number, if it generates the right number then the player will jump. 
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
        //makes player jump by adding force upwards to the rigidbody
        PlayerRb.AddForce(new Vector2(1, 7), ForceMode2D.Impulse);
    }

    void HealthCheck()
    {
        // if the health is less than 0, it will -1 life and set health back to 5
        if (Health <= 0)
        {
            Lives -= 1;
            Health = 5;
        }
    }
    void CoinCheck()
    {
        //if you collect 5 coins then coins are set to 0 and a life is added
        if (Coins >= 5)
        {
            Coins = 0;
            Lives += 1;
        }
    }

    void LivesCheck()
    {
        //if lives are 0, activate the death screen
        if (Lives <= 0)
        {
            GameCan.SetActive(false);
            DeathCan.SetActive(true);
            Time.timeScale = 0;
        }
    }


    void TextUpdate()
    {
        //updates texts to display counters
        livesText.text = ("Lives = " + Lives + "   Health = " + Health);
        coinText.text = ("Coins = " + Coins);
        LevelsComp.text = ("Levels Completed = " + levelsComplete);
    }

    public void MainMenu()
    {
        //changes scene to the main menu scene
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
    
}
