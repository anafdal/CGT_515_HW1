using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheck : MonoBehaviour
{
    public GameObject element;//element
    public GameObject panel;//panel
    public Light lite;//light
    //Vector3 pastColor;//orginal light
    public GameObject table;//table
                       
 
 



    void Start()
    {
        lite = lite.GetComponent<Light>();
        //pastColor = new Vector3(lite.color.r, lite.color.g, lite.color.b);//get original light values

    }
  

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Entered");

            //element.SetActive(false);//elements dissappears
            panel.SetActive(true);//panel appears

            SetColor(table, Color.black);//change color to black


            lite.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));//random color
            lite.intensity = 3;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Exit");

            // element.SetActive(true);//element appears
            panel.SetActive(false);//panel dissappears
            SetColor(table, Color.white);//go back to white

            lite.intensity = 1;

            //lite.color = new Color(pastColor.x, pastColor.y, pastColor.z);//return to original light color
            //lite.color = new Color(0.8392157f, 0.6253533f, 0.1137255f);
        }
    }

    private void SetColor(GameObject name, Color value)
    {
        var cubeRenderer = name.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", value);
    }

}
