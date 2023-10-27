using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RubysControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizantal = Input.GetAxis('Horizontal');
        Debug.Log(horizantal);

        Vector2 position = transform.position;
        position.x = position.x + 0.1f;
        transform.position = position;
    }
}
