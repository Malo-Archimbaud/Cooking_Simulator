using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleasingPlate : MonoBehaviour
{
    public GameObject Plate;
    public GameObject Hand;
    public Animator character;
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
        if (Input.GetKey(KeyCode.R) && Hand.transform.childCount > 0)
        {
            Plate.transform.SetParent(null);
            character.SetBool("HavePlate", false);
            Plate.transform.transform.position = new Vector3(-14, (float)1.428, 25);
            Plate.transform.transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
