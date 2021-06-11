using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene2 : MonoBehaviour
{
    KnifeTrigger knifeTrigger;
    
    
    int maxScore = 4;
    public float slowMotion = 0.5f;

    
    public float secondsLeft = 15.0f;
    public bool takingAway = false;

    public int SceneIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        knifeTrigger = GameObject.FindGameObjectWithTag("Player").GetComponent<KnifeTrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        if (knifeTrigger.score >= maxScore)
        {
            StartCoroutine(loadNextLevel(2));
        }

        IEnumerator loadNextLevel(int _SceneIndex)
        {

            Time.timeScale = slowMotion;
            yield return new WaitForSeconds(2f * slowMotion);
            Time.timeScale = 1;

            SceneManager.LoadScene(_SceneIndex);

        }
    }
}
