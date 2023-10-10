using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 20.0f;
    public float xRange = 10;
    public GameObject player;

    public GameObject[] bullets;
    public float zMin;
    public float zMax;
    public float verticalInput;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    //keep the player in bounds
    {
        {
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
            verticalInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
            if (transform.position.x < -xRange)
            {
                transform.position = new Vector3(-xRange, transform.position.y,
                transform.position.z);
            }
            if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y,
                transform.position.z);
            }
            if (transform.position.z < zMin)
            {
                transform.position = new Vector3(transform.position.x,
                transform.position.y, zMin);
            }
            if (transform.position.z > zMax)
            {
                transform.position = new Vector3(transform.position.x,
                transform.position.y, zMax);
            }
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);



        }
       
        {
            
            {
               
            }
            

        }
        Vector3 inputVector = new Vector3(
            Input.GetAxisRaw("Horizontal"),   //this is the x axis
            Input.GetAxisRaw("vertical"),     // yep, the y axis. who would have guessed
            0.0f
            );
        transform.Translate(inputVector.normalized * speed * Time.deltaTime);
    }

}
 