using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyscript : MonoBehaviour
{
    Rigidbody myRigid;
    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (pos.x < -11)
        {
            myRigid.AddForce(2, 0, 0);
        }
        if (pos.x > 11)
        {
            myRigid.AddForce(-2, 0, 0);
        }

    }
}
