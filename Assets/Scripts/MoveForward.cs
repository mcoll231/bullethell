using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        {
            StartCoroutine(SelfDestruct());
        }

        IEnumerator SelfDestruct()
        {
            yield return new WaitForSeconds(8f);
            Destroy(gameObject);
        }
        transform.Rotate(0, Random.Range(-4.0f, 4.0f), 0);
    }
    
    // Update is called once per frame 
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
