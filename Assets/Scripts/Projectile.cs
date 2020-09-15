using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed = 8f;
    
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //projectiles constantly moves
        transform.position += transform.forward * speed * Time.deltaTime;
        
        //projectile is automatically destroyed after two seconds if it has not impacted anything in order to keep scene clear.
        Destroy(this.gameObject, 2f);
    }
}
