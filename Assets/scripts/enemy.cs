using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject explosion;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bala")
        {
            Instantiate(explosion,transform.position,transform.rotation);
        }
    }
    void Awake()
    {
        
    }

    void Update()
    {
        
    }
}
