using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    [SerializeField] float firing_rate;
    public GameObject death;
    public bool move;

    // Update is called once per frame
    void Update()
    {
        if(this.move){
            this.transform.Translate(Vector3.up * this.firing_rate * Time.deltaTime);
        }        
    }
    
    void OnTriggerEnter(Collider collider){
        if(collider.tag == "zombie"){
            Destroy(this.gameObject);
        }
    }
}
