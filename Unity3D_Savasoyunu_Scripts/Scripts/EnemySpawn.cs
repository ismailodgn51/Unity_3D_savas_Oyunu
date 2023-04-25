using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject spawnEnemy;
    public GameObject a;

    int sp = 0;

    private void Start()
    {
        Spawn();
    }

    private void Update()
    {
        if (spawnEnemy != null)
        {
            if (spawnEnemy.transform.position.x > 100)
            {
               

                Spawn();
                sp = sp + 3; ;
               
            }
        }

        if (sp == 12)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
           
        }
    }
    public void Spawn()
    {
        spawnEnemy = Instantiate(enemy, this.transform);
    }
     
}
