using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pillers_Movement : MonoBehaviour
{
    public Transform[] spwanPoints;
    public GameObject[] obs;
    public float rate;
    public float wave;      


    // Update is called once per frame
    void Update()
    {
        if (rate <= Time.time)
        {
            rate = Time.time + wave;
            int random = Random.Range(0, spwanPoints.Length);
            int randomA = Random.Range(0, 2);
            Instantiate(obs[randomA], spwanPoints[random].transform.position, Quaternion.identity);
        }
    }
}



