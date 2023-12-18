using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BollController : MonoBehaviour
{
    Rigidbody myRigidbody;
    float timer = 1f;
    [SerializeField]
    public GameObject hp1;
    [SerializeField]
    public GameObject hp2;
    [SerializeField]
    public GameObject hp3;
    [SerializeField]
    public GameObject GameOverText;
    AudioSource audio;

    public int liv = 3;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.AddForce(0, -20, 0);
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        float speed = 4f;
        myRigidbody.velocity = myRigidbody.velocity.normalized * speed;
        timer -= Time.deltaTime;
        if (timer < 0 && myRigidbody.velocity == Vector3.zero)
        {
            myRigidbody.AddForce(0, -20, 0);
        }

        if (transform.position.y < -4)
        {
            timer = 2f;
            liv --;
            transform.position = new Vector3(0, 0, 0);
            myRigidbody.velocity = new Vector3(0, 0, 0);

        }
        if (liv == 2)
        {
            Destroy(hp1);
        }
        if (liv == 1)
        {
            Destroy(hp2);
        }
        if (liv == 0)
        {
            Destroy(hp3);
            GameOverText.transform.position = new Vector3(0, 0, 0);
            Time.timeScale = 0;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        audio.Play();
    }
}
