﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteOpener : MonoBehaviour
{
    public Text pointsText;
   public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + "Points";
    }
}
