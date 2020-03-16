using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Orbit : MonoBehaviour
{
    public float value = 2.0f;

    // Update is called once per frame
    void Update()
    {


        this.transform.Rotate(new Vector3(0,value, 0));//rotate around nucleus or smth else
       // this.transform.Rotate(Vector3.up * Time.deltaTime * speed, Space.Self);//rotate around nucleus or smth else

    }
}
