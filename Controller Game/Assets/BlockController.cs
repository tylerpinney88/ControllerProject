using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public GameObject Block1, Block2, Block3, Block4, Block5, Block6, Block7, Block8, Block9, Block10, Block11, Block12, Block13, Block14, Block15, Block16, Block17, Block18;
    public bool Block1Active, Block2Active, Block3Active, Block4Active, Block5Active, Block6Active, Block7Active, Block8Active, Block9Active, Block10Active, Block11Active, Block12Active, Block13Active, Block14Active, Block15Active, Block16Active, Block17Active, Block18Active;
    void Start()
    {
        Time.timeScale = 0.5f;
    }


    void Update()
    {
        //Toggles each Hardcoded control to on and off
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Block1Active = !Block1Active;
            Block1.SetActive(Block1Active); 
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Block2Active = !Block2Active;
            Block2.SetActive(Block2Active);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Block3Active = !Block3Active;
            Block3.SetActive(Block3Active);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Block4Active = !Block4Active;
            Block4.SetActive(Block4Active);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Block5Active = !Block5Active;
            Block5.SetActive(Block5Active);
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            Block6Active = !Block6Active;
            Block6.SetActive(Block6Active);
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            Block7Active = !Block7Active;
            Block7.SetActive(Block7Active);
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            Block8Active = !Block8Active;
            Block8.SetActive(Block8Active);
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            Block9Active = !Block9Active;
            Block9.SetActive(Block9Active);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Block10Active = !Block10Active;
            Block10.SetActive(Block10Active);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Block11Active = !Block11Active;
            Block11.SetActive(Block11Active);
        }
            if (Input.GetKeyDown(KeyCode.E))
        {
            Block12Active = !Block12Active;
            Block12.SetActive(Block12Active);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Block13Active = !Block13Active;
            Block13.SetActive(Block13Active);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Block14Active = !Block14Active;
            Block14.SetActive(Block14Active);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            Block15Active = !Block15Active;
            Block15.SetActive(Block15Active);
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            Block16Active = !Block16Active;
            Block16.SetActive(Block16Active);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            Block17Active = !Block17Active;
            Block17.SetActive(Block17Active);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Block18Active = !Block18Active;
            Block18.SetActive(Block18Active);
        }
    }
}
