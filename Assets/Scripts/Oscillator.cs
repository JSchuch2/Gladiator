using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    public GameObject center;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //Executes orbitaround
        OrbitAround();
    }

    //custom movement script for game, allowing us to move around the arena in a full circle while hugging the sides
    void OrbitAround()
    {
        if (Input.GetKey(KeyCode.A))
        {
        transform.RotateAround (center.transform.position, Vector3.up, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
        transform.RotateAround (center.transform.position, Vector3.down, speed * Time.deltaTime);
        }
    }
}
