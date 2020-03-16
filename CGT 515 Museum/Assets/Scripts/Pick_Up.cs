using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_Up : MonoBehaviour
{
    public Transform Destination;
    private Vector3 past;
    public Vector3 Combiner; 
   

    private void Start()
    {
        past = this.transform.position;//original position
    }
  
    private void OnMouseDown()
    {
        //turn off gravity and collider
       // GetComponent<Rigidbody>().useGravity = false;
        GetComponent<BoxCollider>().enabled = false;

        //move postion
        this.transform.position = Destination.position;

        //parent
        this.transform.parent = GameObject.Find("Destination").transform;
        
    }

    private void OnMouseUp()
    {
        //do the inverse of before
        this.transform.parent = null;
       // GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;

        this.transform.position = Combiner;//go to Combiner

    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.B))
        {
            this.transform.position = past;//go to original position
        }
    }

}
