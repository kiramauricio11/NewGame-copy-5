using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//new line
using UnityEngine.SceneManagement;//new line

public class TimeLimit : MonoBehaviour
{

   // public GameObject timeDisplay;
  //  public int seconds = 30;
   // public bool decuctingTime; //useful for game over
    public GameObject gameOverText;
    public GameObject FadeOut;
    public GameObject pshoot; 
    public GameObject player;
    public GameObject eshoot;
    public GameObject Eplayer;
    public GameObject player1;
    public GameObject Eplayer1;
    public GameObject player2;
    public GameObject Eplayer2;
    public GameObject gameWintext;
    public GameObject gameLosetext;

    //new lines
    public float timeValue = 90;
    public Text timerText;
    


    // Update is called once per frame
    void Update()
    {
        

        if (Scoreboard.scoreCount >= 25)
        {
            pshoot.GetComponent<ShootParticles>().enabled = false;
            player.GetComponent<SoldierScript>().enabled = false;
            eshoot.GetComponent<AIShooter>().enabled = false;
            Eplayer.GetComponent<EnemySoldier>().enabled = false;
            player1.GetComponent<TeamSoldier>().enabled = false;
            Eplayer1.GetComponent<EnemySoldier>().enabled = false;
            player2.GetComponent<TeamSoldier>().enabled = false;
            Eplayer2.GetComponent<EnemySoldier>().enabled = false;
            gameWintext.SetActive(true);
            FadeOut.SetActive(true);
        }

        else if (Scoreboard.EscoreCount >= 25) 
        {
            pshoot.GetComponent<ShootParticles>().enabled = false;
            player.GetComponent<SoldierScript>().enabled = false;
            eshoot.GetComponent<AIShooter>().enabled = false;
            Eplayer.GetComponent<EnemySoldier>().enabled = false;
            player1.GetComponent<TeamSoldier>().enabled = false;
            Eplayer1.GetComponent<EnemySoldier>().enabled = false;
            player2.GetComponent<TeamSoldier>().enabled = false;
            Eplayer2.GetComponent<EnemySoldier>().enabled = false;
            gameLosetext.SetActive(true);
            FadeOut.SetActive(true);
        }

        else if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }


        else if (timeValue == 0 && Scoreboard.scoreCount <= 25 && Scoreboard.EscoreCount <= 25)
        {
            player.GetComponent<SoldierScript>().enabled = false;
            timeValue = 0;
            gameOverText.SetActive(true);
            FadeOut.SetActive(true);
            //StartCoroutine(Respawnlvl());// have to tell it to do it
            // SceneManager.LoadScene(1);
        }


        else
        {
            timeValue = 0;
        }

        DisplayTime(timeValue);
        /* 
        else if (seconds == 0 && Scoreboard.scoreCount <= 25 && Scoreboard.EscoreCount <= 25)
        {
            player.GetComponent<SoldierScript>().enabled = false; 
            seconds = 0; 
            gameOverText.SetActive(true);
            FadeOut.SetActive(true);
            //StartCoroutine(Respawnlvl());// have to tell it to do it
            // SceneManager.LoadScene(1);
        }
        
        
        else
        {
            if (decuctingTime == false)
            {
                decuctingTime = true;
                StartCoroutine(DeductSecond());// have to tell it to do it
            }
        }
        

       */

    }

    /*
    IEnumerator DeductSecond()
    {
        yield return new WaitForSeconds(1);//minus 1 second
        seconds -= 1;
        timeDisplay.GetComponent<Text>().text = "Time: " + seconds;
        decuctingTime = false;
    }

    IEnumerator Respawnlvl()
    {
        yield return new WaitForSeconds(3);//minus 3 second
        SceneManager.LoadScene(1);
    }
    */


    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
