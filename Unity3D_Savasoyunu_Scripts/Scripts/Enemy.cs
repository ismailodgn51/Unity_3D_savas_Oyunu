using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public int hiz = 100;


  

    private void Update()
    {
        GetComponent<Rigidbody>().AddForce(hiz * Time.deltaTime, 0, 0);
        

    }

   

}


