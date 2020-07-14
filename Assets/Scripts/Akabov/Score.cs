using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
   // public GameObject hiScore;

    void Start()
    {
        showScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showScore()
    {
        scoreText.text = EnemyController.score.ToString() + " чортів";
    }
}
