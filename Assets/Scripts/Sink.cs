using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sink : MonoBehaviour
{
    public GameObject Water;
    public GameObject Water2;
    // Start is called before the first frame update
    void Start()
    {
        Water.SetActive(false);
        Water2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            Water.SetActive(true);
            Water2.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            Water.SetActive(false);
            Water2.SetActive(false);
        }
    }
}
