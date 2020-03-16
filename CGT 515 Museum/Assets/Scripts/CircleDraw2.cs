using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDraw2 : MonoBehaviour
{
    public GameObject center;

    float radius = 0.0f;
    //float radiusSec = 0.0f;
    float theta_scale = 0.01f;//Set lower to add more points
    int size; //Total number of points in circle
    LineRenderer lineRenderer;//the line(s)



    private void Start()
    {

        Transform electron = transform.Find("Electron (2)");//Get one child
        //Debug.Log(electron.localPosition);
        radius = Vector3.Distance(center.transform.position, electron.transform.position);//distance between first electron and nucleus
                                                                                           //Debug.Log(radius);
                                                                                           //Debug.Log(transform.childCount);

        /* if(transform.childCount > 2)
          {
              Transform electronThird = transform.Find("Electron (2)");//Get one child
              radiusSec = Vector3.Distance(nucleus.transform.position, electronThird.transform.position);//distance between first electron and nucleus
              Debug.Log(electronThird.localPosition);
          }*/
    }

    void Awake()
    {
        float sizeValue = (2.0f * Mathf.PI) / theta_scale;
        size = (int)sizeValue;
        size++;

        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.startWidth = 0.05f;//change thickness
        lineRenderer.endWidth = 0.05f;
        lineRenderer.positionCount = size;

        lineRenderer.material.color = Color.yellow;//change color to yellow

        /* if(transform.childCount > 2)//if more than two electrons only
         {
             lr = gameObject.AddComponent<LineRenderer>();
             lr.material = new Material(Shader.Find("Sprites/Default"));
             lr.startWidth = 0.05f;//change thickness
             lr.endWidth = 0.05f;
             lr.positionCount = size;
             lr.material.color = Color.yellow;//change color to yellow
         }*/
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 pos;
        float theta = 0f;

        for (int i = 0; i < size; i++)
        {
            theta += (2.0f * Mathf.PI * theta_scale);
            float x = radius * Mathf.Cos(theta);//the center will be the nucleus
            float z = radius * Mathf.Sin(theta);

            x += gameObject.transform.position.x;
            z += gameObject.transform.position.z;
            pos = new Vector3(x, 6, z);
            lineRenderer.SetPosition(i, pos);
        }

        /*  if (transform.childCount > 2)
          {
              for (int j = 0; j < size;j++)
              {
                  theta += (2.0f * Mathf.PI * theta_scale);
                  float x = radiusSec * Mathf.Cos(theta);//the center will be the nucleus
                  float z = radiusSec * Mathf.Sin(theta);

                  x += gameObject.transform.position.x;
                  z += gameObject.transform.position.z;
                  pos = new Vector3(x, 6, z);
                  lr.SetPosition(j, pos);
              }
          }*/
    }
}
