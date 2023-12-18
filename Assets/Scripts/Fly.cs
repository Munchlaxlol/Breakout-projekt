using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    Rigidbody rog;
    // Start is called before the first frame update
    void Start()
    {
        rog = GetComponent<Rigidbody>();
        float speed = 4f;
        rog.velocity = rog.velocity.normalized * speed;
        rog.AddForce(0, 100, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
