using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kalp : MonoBehaviour
{
    // Start is called before the first frame update
   
        float zaman_aralik = 5.0f;

        float kalan_zaman = 0.0f;
         public int hiz;
    public GameObject kalp;
    public void OnTriggerEnter(Collider collision)
        {
            if (collision.gameObject.tag == "bullet")   //ýs trigger tikli olmalý.
            {
                hiz = hiz * 2;

            }
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time >= kalan_zaman)
        {
            kalp.SetActive(true);

            kalan_zaman = zaman_aralik + Time.time;
        }
        else
        {
            kalp.SetActive(false);
        }
    }
}
