using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    GameObject shotGun;
    [SerializeField]
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(shotGun, player.transform.position + new Vector3(0, 2, 0), Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
