using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class BulletMove : MonoBehaviour
{
    public int hiz = 30000;
    EnemySpawn enemySpawn;
    public int a=0;
  
   // public GameObject enemy;
   // public GameObject enemy1;
   // public GameObject enemy2;
    Canvas[] CanvasPlayerGUIs;
    private void Start()
    {
       CanvasPlayerGUIs = FindObjectsOfType<Canvas>();
        enemySpawn = GameObject.FindObjectOfType<EnemySpawn>();
        Destroy(gameObject, 10.0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Destroy(other.gameObject);
            a++;

        }
        else if (other.gameObject.tag == "enemy1")
        {
            Destroy(other.gameObject);
            a++;
        }
        else if (other.gameObject.tag == "enemy2")
        {
            Destroy(other.gameObject);
            a++;
        }
        if (other.gameObject.tag == "kalp")
        {

            Destroy(other.gameObject);

            hiz += 5000;
             Debug.Log(hiz);
              
        }
        if (a == 3)
        {
            // Time.timeScale = 0.0f;
            Debug.Log("Game Over");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }
    // Update is called once per frame
    public void Update()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, hiz * Time.deltaTime);
      /*  if (enemyNum == 3)
        {
           
            foreach (Canvas CanvasPlayerGUI in CanvasPlayerGUIs)
            {

                if (CanvasPlayerGUI.name == "MyCanvas")
                {
                    CanvasPlayerGUI.enabled = true;
                    break;

                }
            }
        }*/
    }

   /* public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            enemyNum++;
            Destroy(other.gameObject);
          
            Debug.Log(enemyNum);

        }*/

    }

