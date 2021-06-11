using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeTrigger : MonoBehaviour
{
    
    public GameObject cutEffect;
    bool isCut = false;
    public Text scoreText;
    public Rigidbody2D rb;
    public GameObject[] slicedFruits;
    public float score = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (var slicedFruit in slicedFruits)
        {
            if (slicedFruit.tag == collision.tag)
            {
                cutEffect.GetComponent<ParticleSystem>().playOnAwake = true;
                Instantiate(cutEffect,transform.position,Quaternion.identity);
                
                SoundManagerScript.PlaySound();
                score++;
                scoreText.text = score.ToString();
                Instantiate(slicedFruit, collision.transform);
                slicedFruit.GetComponent<CircleCollider2D>().isTrigger = false;
                Destroy(collision.gameObject, 1f);
                Color a = collision.GetComponent<SpriteRenderer>().color;
                a.a = 0f;
                collision.GetComponent<SpriteRenderer>().color = a;
            }
      
        }


        

    }
    
}
