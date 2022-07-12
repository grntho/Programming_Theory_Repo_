using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class Score : MonoBehaviour
{
    public Text currentScore;
    public Text bestScore;

    public float scoreCount;
    public float bestScoreCount;

    public float pointsPerSecond;
    public bool scoreIncreasing;

    private PlayerController playerControllerScript;

    private void Start()
    {
        if(PlayerPrefs.GetFloat("Best Score: ") != null)
        {
            bestScoreCount = PlayerPrefs.GetFloat("Best Score: ");
        }

        playerControllerScript =
        GameObject.Find("Player").GetComponent<PlayerController>();
        playerControllerScript = FindObjectOfType<PlayerController>();

    }
    void Update()
    {
       

        if (scoreIncreasing == true)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }
        
 
        if (scoreCount > bestScoreCount)
        {
            bestScoreCount = scoreCount;
            PlayerPrefs.SetFloat("Best Score: ", bestScoreCount);
        }

        currentScore.text = "Score: " + Mathf.Round (scoreCount);
        bestScore.text = "Best Score: " + Mathf.Round (bestScoreCount);
    }


    
}
