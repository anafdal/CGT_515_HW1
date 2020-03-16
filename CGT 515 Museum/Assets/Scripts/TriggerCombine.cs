using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerCombine : MonoBehaviour
{
    //public GameObject element;//element
    //public GameObject panel;//panel
    public Text news;
    //public GameObject el;
    //private  GameObject[] myObjects = new GameObject[10];//array
    private List<GameObject> myObjects = new List<GameObject>();
    private bool[] water = new bool [2];
    //private bool[] carbonDioxide = new bool[2];


    void Start()
    {
        news.text = "Combine Elements";
        

    }


    private void OnTriggerEnter(Collider other)
    {


        //el = GameObject.Find("/Element/Hydrogen");
        //element.SetActive(false);//elements dissappears
        //panel.SetActive(false);//panel appears
        //news.SetActive(true);
        //news.text = "Need More elements"
        bool doIt = true;///got them or not


        if (other.name == "Hydrogen(1)")//hydrogen 1
        {

            water[0] = true;
            Debug.Log(water[0]);


            if (myObjects.Count < 2)///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                news.text = "Hydrogen";
                myObjects.Add(other.gameObject);

            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    Debug.Log(water[i]);

                    if (water[i] != true)
                    {
                        doIt = false;//if not this is false

                    }

                }

                if (doIt)
                {
                    news.text = "You got WATER!";////////////////////////////////////////////////////////////////////////////////////////////////

                }
                else
                {
                    news.text = "Wrong Combination! Press B and try again!";//////////////////////////////////////////////////////////////
                }
            }









        }
        else if (other.name == "Helium(2)")//helium 2
        {


            if (myObjects.Count < 2)///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                news.text = "Helium";
                myObjects.Add(other.gameObject); ;

            }
            else
            {

                news.text = "Try Again";
            }
        }
        else if (other.name == "Lithium(3)")//lithium 3
        {

            if (myObjects.Count < 2)///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                news.text = "Lithium";
                myObjects.Add(other.gameObject);

            }
            else
            {

                news.text = "Try Again";
            }


        }
        else if (other.name == "Beryllium(4)")//beryllium 4
        {

           
            if (myObjects.Count < 2)///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                news.text = "Beryllium";
                myObjects.Add(other.gameObject);

            }
            else
            {

                news.text = "Try Again";
            }



        }
        else if (other.name == "Boron(5)")//boron 5
        {


            if (myObjects.Count < 2)///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                news.text = "Boron";
                myObjects.Add(other.gameObject);

            }
            else
            {

                news.text = "Try Again";
            }



        }
        else if (other.name == "Carbon(6)")//carbon 6
        {


            //carbonDioxide[0] = true;

            if (myObjects.Count < 2)///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                news.text = "Carbon";
                myObjects.Add(other.gameObject);

            }
            else
            {

                news.text = "Try Again";
            }



        }
        else if (other.name == "Nitrogen(7)")//nitrogen 7
        {


            if (myObjects.Count < 2)///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                news.text = "Nitrogen";
                myObjects.Add(other.gameObject);

            }
            else
            {

                news.text = "Try Again";
            }



        }
        else if (other.name == "Oxygen(8)")//oxyegn 8
        {
            water[1] = true;
            // Debug.Log(water[1]);
            Debug.Log(myObjects.Count);

            if (myObjects.Count < 2)///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                news.text = "Oxygen";
                myObjects.Add(other.gameObject);

            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    Debug.Log(water[i]);

                    if (water[i] != true)
                    {
                        doIt = false;//if not this is false

                    }

                }

                if (doIt)
                {
                    news.text = "You got WATER!";////////////////////////////////////////////////////////////////////////////////////////////////

                }
                else
                {
                    news.text = "Wrong Combination! Press B and try again!";//////////////////////////////////////////////////////////////
                }
            }

        }
        else if (other.name == "Fluorine(9)")//fluorine 9
        {

            if (myObjects.Count < 2)///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                news.text = "Fluorine";
                myObjects.Add(other.gameObject);

            }
            else
            {

                news.text = "Try Again";
            }
        }
        else if (other.name == "Neon(10)")//neon 10
        {

            if (myObjects.Count < 2)///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                news.text = "Neon";
                myObjects.Add(other.gameObject);

            }
            else
            {

                news.text = "Try Again";
            }
        }


       
      

    }
       
    private void OnTriggerExit(Collider other)
    {
        //panel.SetActive(true);
        //news.SetActive(false);
        news.text = "Combine Elements";

  
    }
   void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {

            myObjects.Clear();
         
            for (int i = 0; i < 2; i++)//////////////////////////////////////////////////////////////////////////////////////////when done
                    {
                        water[i] = false;
                        Debug.Log(water[i]);

                    }

        }
    }


}
