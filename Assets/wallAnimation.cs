using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallAnimation : MonoBehaviour
{
    public Material wall;
    private float offset = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector2 ofst = new Vector2(offset/100, 0f);

        wall.mainTextureOffset = ofst;

        if (offset <= 1000)
        {
            offset++;
        }
        else
        {
            offset = 0;
        }
    }
}
