using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Movement : MonoBehaviour
{
    public GameObject center;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int newrandomNumber = Random.Range(1, 4);

        if (newrandomNumber == 1)
        {
        transform.RotateAround (center.transform.position, Vector3.up, speed * Time.deltaTime);
        }
        if (newrandomNumber == 2)
        {
        transform.RotateAround (center.transform.position, Vector3.down, speed * Time.deltaTime);
        }
        if (newrandomNumber == 3)
        {
        //stand still, do nothing
        }
        

    }
}
