using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    
    public Vector2 velocity;

    void FixedUpdate () {
        GetComponent<Rigidbody2D>().velocity = velocity;
    }
    
    void OnMouseDown() {
        
        Destroy(gameObject);
    }
}
