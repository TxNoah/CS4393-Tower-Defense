using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zom_Movement : MonoBehaviour
{

    [SerializeField] float zom_speed;
    public bool move;

    // Update is called once per frame
    void Update()
    {
        if(this.move){
            this.transform.Translate(Vector3.left * this.zom_speed * Time.deltaTime);
        }        
    }
}
