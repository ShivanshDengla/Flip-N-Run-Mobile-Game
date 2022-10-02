using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedSpawnPoint : MonoBehaviour
{
    public GameObject obstacl;

    void Start()
    {
        Instantiate(obstacl, transform.position, Quaternion.identity);
    }
}
