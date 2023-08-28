using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowtheScore : MonoBehaviour
{
    public static int score;
    public static int newScore;
    public Text scoreText;
    
        void Start()
    {
        scoreText.text = PlayerPrefs.GetInt("EndScore").ToString();
    }

    
}
