using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
        public Material floor0;
        public Material wall0;
        public Material floor1;
        public Material wall1;
    private GameObject[] wallObjects;
    private GameObject[] floorObjects;
    private Material m;
    public int theme = 0;

        // Start is called before the first frame update

        void start()
    {
        
    }


        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                changeTheme(0);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                changeTheme(1);
            }
        }


    private void FixedUpdate()
    {
        wallObjects = GameObject.FindGameObjectsWithTag("wall");
        floorObjects = GameObject.FindGameObjectsWithTag("floor");
    }

    void changeTheme (int themeInt)
        {
        theme = themeInt;

            string floor = "floor" + themeInt;
            string wall = "wall" + themeInt;

            Debug.Log(floor + wall);
        

        for (int n = 0; n < wallObjects.Length; n++)
        {
            if (theme == 0)
            {
                GameObject g = wallObjects[n];
                g.GetComponent<MeshRenderer>().material = wall0;
            }

            if (theme == 1)
            {
                GameObject g = wallObjects[n];
                g.GetComponent<MeshRenderer>().material = wall1;
            }

        }

        for (int n = 0; n < floorObjects.Length; n++)
        {
            if (theme == 0)
            {
                GameObject g = wallObjects[n];
                g.GetComponent<MeshRenderer>().material = floor0;
            }

            if (theme == 1)
            {
                GameObject g = wallObjects[n];
                g.GetComponent<MeshRenderer>().material = floor1;
            }

        }




    }
}
