using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbingKnife : MonoBehaviour
{
    public GameObject Knife;
    public GameObject Hand;
    private GameObject Grabbed;
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
        {
            Grabbed = Knife;
            Knife.transform.SetParent(Hand.transform);
            Knife.transform.transform.localPosition = new Vector3(-0.1f, 0, 0.38f);
            Knife.transform.transform.localEulerAngles = new Vector3(-97, -95, -7);
        }
    }
}
