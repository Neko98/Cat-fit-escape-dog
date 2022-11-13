using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{
    public Text pointsText;

    public void Setup(int score){
        gameObject.SetActive(true);
        pointsText.text = "Your Score : " + score.ToString() + " Points";
    }
}
