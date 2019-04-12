using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class GameController : MonoBehaviour
{
    [SerializeField] private string newLevel;
    GameObject[] Enemies;
    public GameObject EnemyPrefab;
    private Vector3 epos;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(newLevel);
        }
    }

    private void Awake()
    {
        Enemies = new GameObject[2];
        epos.x = 6.5f;
        epos.y = 0.6f;

  
/*        for (int ii = 0; ii < Enemies.Length; ii++)
        {
            GameObject e1 = Instantiate(EnemyPrefab);
            epos.x = 2.5f;
            epos.y = -2.4f;
            e1.transform.position = epos;
            Enemies[ii] = e1;
        }
*/
  
    }

    void LevelBuilder()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
