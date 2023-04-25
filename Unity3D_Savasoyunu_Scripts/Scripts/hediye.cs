using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hediye : MonoBehaviour
{
    public GameObject[] hediyeler ;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnHayvan", 1, 4);

    }

    // Update is called once per frame
    void Update()
    {



    }

    void SpawnHayvan()
    {
        int hayvanIndis = Random.Range(0, hediyeler.Length);
        int konumX = Random.Range(-10,20);
        Instantiate(hediyeler[hayvanIndis], new Vector3(konumX, 15, 15), hediyeler[hayvanIndis].transform.rotation);
    }

}
