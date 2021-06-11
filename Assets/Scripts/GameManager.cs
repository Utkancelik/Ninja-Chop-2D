using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    KnifeTrigger knifeTrigger;
    KnifeController knifeController;

    public Text scoreText;
    int maxScore = 4;
    public float slowMotion = 0.5f;

    public Text timerText;
    public float secondsLeft = 15.0f;
    public bool takingAway = false;

    public int SceneIndex = 0;


    void Start()
    {
        knifeTrigger = GameObject.FindGameObjectWithTag("Player").GetComponent<KnifeTrigger>();
        knifeController = GameObject.FindGameObjectWithTag("Player").GetComponent<KnifeController>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Scene index: "+ SceneIndex);
        Debug.Log("knifeTrigger.score: " + knifeTrigger.score);
        Debug.Log(Time.timeScale);
        /*
        if (knifeTrigger.score >= maxScore)
        {
            SceneIndex++;
            Mathf.Clamp(SceneIndex, 0, 2);
            if (SceneIndex >= 1)
            {
                SceneIndex = 1;
                StartCoroutine(loadNextLevel(SceneIndex));

            }
            else if (SceneIndex > 1 && SceneIndex >= 2)
            {
                SceneIndex = 2;
                StartCoroutine(loadNextLevel(SceneIndex));
            }
            
           
        }
        */
        if (!knifeController.hicTikladiMi)
        {
            StartCoroutine(TimerTake());
        }
        
        if (secondsLeft <= 0f)
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
        
    }
    /*
    IEnumerator loadNextLevel(int _SceneIndex)
    {
        
        Time.timeScale = slowMotion;
        yield return new WaitForSeconds(2f * slowMotion);
        Time.timeScale = 1;
        
        SceneManager.LoadScene(_SceneIndex);
        
    }
    */
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 0.005f;
        timerText.text = "00:" + secondsLeft.ToString();

    }
}
