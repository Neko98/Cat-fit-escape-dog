using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text text;
    public int score;
    void Start()
    {
        score = PlayerPrefs.GetInt("score",score);
        text.text = "SCORE : " + score + " Points";
    }
}
