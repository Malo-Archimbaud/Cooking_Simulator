using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDoor : MonoBehaviour
{
    public Animator MoveDoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
            MoveDoor.SetBool("Moving", true);
        if (Input.GetKey(KeyCode.R))
            MoveDoor.SetBool("Moving", false);
    }
}
