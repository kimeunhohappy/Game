using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 direction;
    void Start()
    {
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
        
        direction.Normalize();
        
        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
}