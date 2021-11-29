using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("head"))
            col.transform.position = spawnPoint.position;
    }
}
