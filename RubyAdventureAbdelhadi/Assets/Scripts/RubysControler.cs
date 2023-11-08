using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RubysControler : MonoBehaviour
{
    Rigidbody2D rgidbody2d;
    float horizantal;
    float vertal;

    // Start is called before the first frame update
     void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        horizantal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");


     }
    void FixedUpdate()
    {
        
    }
}
