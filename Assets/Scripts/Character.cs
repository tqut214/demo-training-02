using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Vector3 CharacterPosition;
    // Start is called before the first frame update
    void Start()
    {
        CharacterPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Move();
    }
    
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Is Jump. This is modified by B2");

        }
    }
    void Move()
    {
        Vector3 moveXDir = new Vector3(Input.GetAxis("Vertical"),0,0);
        CharacterPosition = moveXDir;
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S was press, this was modified by B2");
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D was pressed,commit by B1");
        }
 
    }
}
