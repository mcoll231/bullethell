using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardAndBack : MonoBehaviour
    
{
  //public GameObject[] EnemyBullet;
    public float speed = 40.0f;
    public float reduction = -10;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(Random.Range(-50.0f, 50.0f), Random.Range(-50.0f, 50.0f), 0);

    }
    
    // Update is called once per frame 
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        speed -= reduction * Time.deltaTime;



    }
}

