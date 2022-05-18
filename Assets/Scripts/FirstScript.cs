using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    float speed = 5.0f;
    Vector3 direction = Vector3.zero; // Otherwise you'll start moving without stopping

    private void Start()
    {
        var bmw = new Car("bmw", "x1", 200);
        var audi = Car.audi;
        var audi2 = Car.audi;
        var audi3 = Car.audi;
       
        audi.SetMaxSpeed(10000);
        audi2.SetMaxSpeed(5000);
        audi3.SetMaxSpeed(56446);

        bmw.WhoAmI();
        audi.WhoAmI();
        var speed = audi3.GetMaxSpeed();
        Debug.Log($"This is the max speed {speed}");
    }

    void KeyboardController()
    {
        direction = Vector3.zero;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 10f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left; // The += makes it possible to move diagonally
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.forward;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            direction += Vector3.up;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.back;
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            direction += Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        KeyboardController();
        var testVector = direction * Time.deltaTime * speed; //new Vector3(10, 2, -5);

        transform.position += testVector;
    }
}
