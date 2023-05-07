using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OlioScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) == true) {
            myRigidbody.velocity = moveSpeed * Time.deltaTime * Vector2.left;
            Debug.Log("left");
        }
        else if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            myRigidbody.velocity = moveSpeed * Time.deltaTime * Vector2.up;
            Debug.Log("up");
        }
    }
}
