using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KALPHAREKET : MonoBehaviour
{
    public int hiz = 100;




    private void Update()
    {
        int konumX = Random.Range(-10, 20);
        GetComponent<Rigidbody>().AddForce(0, 0, -hiz * Time.deltaTime);


    }



}


