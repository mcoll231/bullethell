using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
public GameObject[] EnemyBullet;
public float startDelay = 2;
public float spawnInterval = 5.5f;
public float spawnTime = 3f;


    //Start is called before the first frame update
    void Start()
    {
        
        int whichBullet = Random.Range(0, 4);
        Instantiate(EnemyBullet[whichBullet], transform.position, EnemyBullet[whichBullet].transform.rotation);
        

    }

    //Update is called once per frame
    void Update()
    {
        int whichBullet = Random.Range(0, EnemyBullet.Length);
        Instantiate(EnemyBullet[whichBullet], transform.position,
EnemyBullet[whichBullet].transform.rotation);
    } 

}