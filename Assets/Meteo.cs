using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteo : MonoBehaviour
{
    [SerializeField]
    private GameObject roket;
    void Update()
    {
        if (transform.position.y + roket.transform.position.y < -70f)
            transform.position = new Vector3(Random.Range(-4f, 10f), transform.position.y + 100f, 0);
    }
}
