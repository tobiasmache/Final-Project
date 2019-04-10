using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Transform PlayerRestart;
    public SpriteRenderer collectableRenderer;
    private GameObject lightBulb;

    // Start is called before the first frame update
    void Start()
    {
        lightBulb.GetComponent<SpriteRenderer>();
        collectableRenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            collectableRenderer.enabled = false; // disable the renderer
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            PlayerRestart.position = new Vector3(-6.2f, 5.4f, 0f);
        }
        if (other.gameObject.CompareTag("Spike"))
        {
            PlayerRestart.position = new Vector3(-6.2f, 5.4f, 0f);
        }
    }
}
