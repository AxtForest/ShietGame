using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float forwardSpeed = 5f;   //bu hız kamera ile aynı hızda  
    public float maxAngle = 60f; 
    public float rotateSpeed = 0.5f;

    Vector2 firstTouch;
    float currentYAngle = 0f;


    public float maxX = 3f;

    void Update()
    {
        Movement();
    }


    void Movement()
    {
        
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);



        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -maxX, maxX);
        transform.position = pos;



        if (Input.touchCount == 0) return;

        Touch touch = Input.GetTouch(0); 

        if (touch.phase == TouchPhase.Began)
            firstTouch = touch.position;

        if (touch.phase == TouchPhase.Moved)
        {
            float diffX = touch.position.x - firstTouch.x;

           
            currentYAngle += diffX * rotateSpeed;

            
            currentYAngle = Mathf.Clamp(currentYAngle, -maxAngle, maxAngle);

            
            transform.eulerAngles = new Vector3(transform.eulerAngles.x,currentYAngle,transform.eulerAngles.z); // parent durumunda localeuler

            
            firstTouch = touch.position;
        }
    }
}




