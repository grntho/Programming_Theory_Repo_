using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainManager : MonoBehaviour
{
    //text display
    public Text currentScore;
    public Text currentPlayer;
    public Text bestPlayer;

    public GameObject gameOverText;

    public bool isGameOver = false;

    private bool isStarted = false;
    private int playerPoints;

    //static var 4 best player data
    private static int BestScore;
    private static string BestPlayer;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
