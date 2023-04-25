using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class rspammmm : MonoBehaviour
{
    public GameObject kalp;
    public int xPos;
    public int yPos;
    public int enemyCount;

    private void Start()
    {
        StartCoroutine(EnemyDrop());
    }
    IEnumerator EnemyDrop()
    {
        while (enemyCount < 10)
        {
            xPos = Random.Range(1, 30);
            yPos = Random.Range(-8, 8);
            Instantiate(kalp, new Vector3(xPos, yPos, 1), Quaternion.identity);
            yield return new WaitForSeconds(10);
            enemyCount += 1;

           
        }
    }
     
}
