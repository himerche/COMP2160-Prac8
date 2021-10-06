using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalAxis = Input.GetAxis(InputAxes.Horizontal);
        float verticalAxis = Input.GetAxis(InputAxes.Vertical);
        Vector3 direction = (Vector3.right * horizontalAxis) + (Vector3.forward * verticalAxis);
        transform.Translate(direction * movementSpeed * Time.deltaTime);
    }
}
