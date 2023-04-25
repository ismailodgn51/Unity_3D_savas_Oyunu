using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HareketCode : MonoBehaviour
{

    AudioSource audio;
    public AudioClip atessesi;

    [SerializeField]
    int Hiz = 20;

    public GameObject bullet;
    public GameObject roket;
    Rigidbody yercekimi;
    // Use this for initialization
    public int guc;
    void Start()
    {
        yercekimi = GetComponent<Rigidbody>(); ///fiziksel özellikleri alýnmýþ
    }

    // Update is called once per frame
    void Update()
    {

        float ilerigeri = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 hareket = new Vector3(ilerigeri * Hiz,dikey * Hiz, 0);
        yercekimi.AddForce(hareket * guc);//force güç ekle demek

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(bullet, transform.position + new Vector3(0, 0, 1), Quaternion.identity);
            audio = GetComponent<AudioSource>();
            audio.PlayOneShot(atessesi);
        }
    }
} 
