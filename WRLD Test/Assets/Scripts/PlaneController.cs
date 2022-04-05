using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour
{
    //int flyingSpeed = 100;
    //int speedChange = 20;

    //int rotationInt = 5;
    //private void Update()
    //{

    //    if (Input.GetKeyDown(KeyCode.W))
    //    {
    //        flyingSpeed += speedChange;
    //    }

    //    if (Input.GetKeyDown(KeyCode.S))
    //    {
    //        flyingSpeed += -speedChange;
    //    }

    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        transform.RotateAround(transform.position, transform.up, -rotationInt);
    //    }

    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        transform.RotateAround(transform.position, transform.up, rotationInt);
    //    }
    //}
    //private void FixedUpdate()
    //{

    //    transform.position += transform.forward * flyingSpeed * Time.deltaTime;

    //}




    public float speed = 10.0f;

    
    void Update()
    {
        Vector3 moveCamTo = transform.position - transform.forward * 10.0f + transform.up * 5.0f;

        //float bias = 0.96f;
        //Camera.main.transform.position = Camera.main.transform.position * bias + moveCamTo * (1.0f - bias);

        //Camera.main.transform.LookAt(transform.position + transform.forward * 30.0f);

        transform.position += transform.forward * Time.deltaTime * speed;

        speed -= transform.forward.y * Time.deltaTime * 50.0f;

        if (speed < 35.0f)
        {
            speed = 35.0f;
        }

        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

        
    }
}