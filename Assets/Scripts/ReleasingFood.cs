using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleasingFood : MonoBehaviour
{
    private GameObject Food;
    public GameObject Hand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Hand.transform.childCount > 0)
            Food = Hand.transform.GetChild(0).gameObject;
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.R) && Hand.transform.childCount > 0)
        {
            Food.transform.SetParent(null);
            Food.transform.transform.position = new Vector3(-14.24f, 1.428f, 25.208f);
            Food = null;    
        }
    }
}
