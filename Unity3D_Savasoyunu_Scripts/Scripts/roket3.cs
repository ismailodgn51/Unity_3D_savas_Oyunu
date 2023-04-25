using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roket3 : MonoBehaviour
{
    public GameObject[] hediyeler;
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

        Instantiate(hediyeler[hayvanIndis], new Vector3(46, 15, 177), hediyeler[hayvanIndis].transform.rotation);
    }

}
