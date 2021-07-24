﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject realButton;

    public GameObject fakeText;
    public GameObject realText;

    public int currentCash;

    public static int bakerValue = 50;

    public static bool turnOffButton = false;

    void Update()
    {
        currentCash = GlobalCash.CashCount;
        fakeText.GetComponent<Text>().text = "Buy Baker - $" + bakerValue;
        realText.GetComponent<Text>().text = "Buy Baker - $" + bakerValue;
        if(currentCash >= bakerValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        
        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
