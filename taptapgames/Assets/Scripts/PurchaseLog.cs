﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoCookie;
    public GameObject AutoSell;
    public AudioSource playSound;

    public void StartAutoCookie()
    {
        playSound.Play();
        AutoCookie.SetActive(true);
        GlobalCash.CashCount -= GlobalBaker.bakerValue;
        GlobalBaker.bakerValue *= 2;
        GlobalBaker.turnOffButton = true;
        GlobalBaker.bakePerSec += 1;
        GlobalBaker.numberOfBakers += 1;

    }
    public void StartAutoSell()
    {
        playSound.Play();
        AutoSell.SetActive(true);
        GlobalCash.CashCount -= GlobalShop.shopValue;
        GlobalShop.shopValue *= 2;
        GlobalShop.turnOffButton = true;
        GlobalShop.shopPerSec += 1;
        GlobalShop.numberOfShops += 1;

    }
}
