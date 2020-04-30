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

    void HealthCheck()
    {
        if (Health <= 0)
        {
            Lives -= 1;
            Health = 5;
        }
    }
    void CoinCheck()
    {
        if (Coins >= 5)
        {
            Coins = 0;
            Lives += 1;
        }
    }

    void LivesCheck()
    {
        if (Lives <= 0)
        {
            GameCan.SetActive(false);
            DeathCan.SetActive(true);
            Time.timeScale = 0;
        }
    }


    void TextUpdate()
    {
        livesText.text = ("Lives = " + Lives + "   Health = " + Health);
        coinText.text = ("Coins = " + Coins);
        LevelsComp.text = ("Levels Completed = " + levelsComplete);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
    
}
