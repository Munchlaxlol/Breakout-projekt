using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigid;
    float acceleration = 0.01f;
    [SerializeField]
    GameObject shotGun;
    AudioSource yipee;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        yipee = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rigid.AddForce(20, 0, 0);
            yipee.Play();
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigid.AddForce(-20, 0, 0);
            yipee.Play();
        }


    }
    private void Update()
    {
        Time.timeScale += Time.deltaTime * acceleration;
    }
}
