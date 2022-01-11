using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public int score { get; protected set; }
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int beetleValue)
    {
        FMODUnity.RuntimeManager.PlayOneShot("PointsCollect");
        score += beetleValue;
        scoreText.text = "X" + score.ToString();
    }
    public void ChangeHealth(int healthValue)
    {

    }
}
