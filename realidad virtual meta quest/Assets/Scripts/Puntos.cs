using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Puntos : MonoBehaviour
{

    public static Puntos instance;
    public int score = 0;
    public TMP_Text scoreText;
    private void Awake()
    {
        if(instance == null) instance = this;
    }


    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

}
