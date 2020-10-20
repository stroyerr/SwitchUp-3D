using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController playerController;

    public float movementSpeed = 1f;
    float sprint = 1f;
    public float sprintModifier = 10f;
    bool sprintDown = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
  
        {

        

        if (sprintDown)
                    {
                         sprint = sprintModifier;
                    }
                    else
                    {
                        sprint = 1f;
                    }
        Debug.Log("sprintdown" + sprintDown);
        Debug.Log("sprintmod" + sprint);
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical") * sprint;


        

        Vector3 move = transform.right * x + transform.forward * z;
        playerController.Move(move * movementSpeed/10 * Time.deltaTime);

        
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            sprintDown = true;
            Debug.Log("down");
        }

        if (!Input.GetKeyDown(KeyCode.LeftShift))
        {
            sprintDown = false;
        }
    }
}
