﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpawnableController : MonoBehaviour
{

    public GameObject Bomb;
    public GameObject Coin;
    public int ChanceToGenerate;
    public int ChanceToGenerateMax;
    public int ChanceToGenerateMin;

    void Start()
    {
        Bomb.SetActive (false);
        Coin.SetActive(false);
        ChanceToGenerate = Random.Range(ChanceToGenerateMin, ChanceToGenerateMax);
    }


    void Update()
    {
        if (ChanceToGenerate == 0)
        {
            Bomb.SetActive(true);
        }

        if (ChanceToGenerate == 1)
        {
            Coin.SetActive(true);
        }
    }
}