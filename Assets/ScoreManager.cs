using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    Text Text;
    void Start()
    {
        score = 100;
        Text = GetComponent<Text> ();
        score = PlayerPrefs.GetInt("score",score);
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = "SCORE : " + score + "Points";
    }
}
