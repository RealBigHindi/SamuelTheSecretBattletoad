using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    Vector3 updated_vector = new Vector3(2,2,2);
    public float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
         transform.position = transform.position + new Vector3(speed,speed,speed);
    }
}
