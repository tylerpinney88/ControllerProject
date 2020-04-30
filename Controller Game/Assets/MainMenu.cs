using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject MainMenuCan;
    public GameObject OptionsMenuCan;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    public void Options()
    {
        MainMenuCan.SetActive(false);
        OptionsMenuCan.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Back()
    {
        OptionsMenuCan.SetActive(false);
        MainMenuCan.SetActive(true);
    }
}
