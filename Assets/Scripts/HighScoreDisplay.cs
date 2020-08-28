using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreDisplay : MonoBehaviour
{
    void Start()
    {
        Text text = GetComponent<Text>();
        if (text != null) {
            text.text = "High Score " + PlayerPrefs.GetInt("Score", 0);
        }
    }
}
