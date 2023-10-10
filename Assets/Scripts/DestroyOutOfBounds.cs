using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 200;
    private float lowerBound = -400;
    GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(bullet);
        }
        else if (transform.position.z < lowerBound)
        {
        
            Destroy(bullet);
        }
    }
}