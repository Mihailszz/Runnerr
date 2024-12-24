using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HighestScore : MonoBehaviour
{
    public Text Highestscore;
    private void Start()
    {
       Highestscore.text= PlayerPrefs.GetInt("highestscore").ToString();
    }

}
