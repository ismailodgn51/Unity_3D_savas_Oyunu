using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roket1spam : MonoBehaviour
{
    public GameObject[] hediyeler;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnHayvan", 1, 4);

    }
    public int xPos;
    // Update is called once per frame
    void Update()
    {



    }

    void SpawnHayvan()
    {
        xPos = Random.Range(-4, -20);
        int hayvanIndis = Random.Range(0, hediyeler.Length);
      
        Instantiate(hediyeler[hayvanIndis], new Vector3(-6, 15, 177), hediyeler[hayvanIndis].transform.rotation);
    }

}
