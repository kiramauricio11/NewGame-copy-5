using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// new line

public class Scoreboard : MonoBehaviour
{
    
    public GameObject textScore; //new line
    public GameObject EtextScore; //new line

    public static int scoreCount;                  //new line
    public static int EscoreCount;                  //new line

    void Update()
    {
        

              //  scoreCount += 1;    //new line
                textScore.GetComponent<Text>().text = "Your score: " + scoreCount;//new line
                EtextScore.GetComponent<Text>().text = "Enemy score: " + EscoreCount;//new line


    }
}
