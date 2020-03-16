using UnityEngine;

public class CircleDraw : MonoBehaviour
{
    public GameObject nucleus;
    float radius = 0.0f;
    float theta_scale = 0.01f;//Set lower to add more points
    int size; //Total number of points in circle
    LineRenderer lineRenderer;
     




    private void Start()
    {
        
        Transform electron = transform.Find("Electron");//Get one child
        //Debug.Log(electron.localPosition);
        radius = Vector3.Distance(nucleus.transform.position, electron.transform.position);//distance between first electron and nucleus
        //Debug.Log(radius);
        //Debug.Log(transform.childCount);
        
     
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

        
    }
}
