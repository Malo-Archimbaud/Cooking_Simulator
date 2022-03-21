using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbingFood : MonoBehaviour
{
    public GameObject food; 
    public GameObject Texts;
    // Start is called before the first frame update
    void Start()
    {
        Texts.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        Texts.SetActive(true);

    }

    private void OnTriggerExit(Collider other)
    {
        Texts.SetActive(false);
    }
}
