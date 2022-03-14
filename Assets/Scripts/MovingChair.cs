using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingChair : MonoBehaviour
{
    public Animator MoveChair;
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
            MoveChair.SetBool("Move", true);
        if (Input.GetKey(KeyCode.R))
            MoveChair.SetBool("Move", false);
    }
}
