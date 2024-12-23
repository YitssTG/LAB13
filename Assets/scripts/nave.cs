using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nave : MonoBehaviour
{
    Rigidbody2D _componentRigidbody2D;
    public float velocity;
    float horizontal;
    float vertical;
    public GameObject prefab;
    public AudioSource sfxManager;
    void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(prefab, transform.position, transform.rotation);
            sfxManager.Play();
        }
    }
    private void FixedUpdate()
    {
        _componentRigidbody2D.velocity = new Vector2(horizontal * velocity, vertical * velocity);
    }
}
