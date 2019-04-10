﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Transform PlayerRestart;

    //Rij Heart
    private int health;
    public GameObject Heart_on_Screen;
    public Sprite Heart_on;
    public Sprite Heart_off;
    GameObject[] hearts;
    private Vector3 hpos;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    //


    // Start is called before the first frame update
    void Awake()
    {
        //Rij Heart
            spriteRenderer = GetComponent<SpriteRenderer>();
            animator = GetComponent<Animator>();
            //healthtext = health.ToString();
            Debug.Log("Health: " + health);

            hearts = new GameObject[3];
            hpos.x = 6.9f;
            hpos.y = 4.5f;

             for (int ii = 0; ii < hearts.Length; ii++)
             {
                GameObject heart1 = Instantiate(Heart_on_Screen);
                heart1.transform.position = hpos;
                hearts[ii] = heart1;
                hpos.x = hpos.x + 0.8f;
             }
        //

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            GameObject.Find("Collectable").GetComponent<SpriteRenderer>().enabled = false;

        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            PlayerRestart.position = new Vector3(-6.2f, 5.4f, 0f);
            health++;
            Debug.Log("Health: " + health);
            Change_Heart();

        }
        if (other.gameObject.CompareTag("Spike"))
        {
            PlayerRestart.position = new Vector3(-6.2f, 5.4f, 0f);
            health++;
            Debug.Log("Health: " + health);
            Change_Heart();
            //Heart_on_Screen.gameObject.GetComponent<SpriteRenderer>().sprite = Heart_off;
            //Debug.Log("Health: " + health);

        }
    }

    void Change_Heart()
    {
        if (health == -1)
        {
            for (int ii = 0; ii < hearts.Length; ii++)
            {
                hearts[ii].gameObject.GetComponent<SpriteRenderer>().sprite = Heart_on;
            }
        }

        else
        {
            for (int ii = 0; ii < hearts.Length; ii++)
            {
                hearts[health - 1].gameObject.GetComponent<SpriteRenderer>().sprite = Heart_off;
            }
        }
    }

}
