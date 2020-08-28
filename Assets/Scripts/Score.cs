using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;

    void Start()
    {
        score = 0;
    }

    void OnDestroy()
    {
        int previousScore = PlayerPrefs.GetInt("Score", 0);
        if (score > previousScore) {
            PlayerPrefs.SetInt("Score", score);
        }
    }
}
