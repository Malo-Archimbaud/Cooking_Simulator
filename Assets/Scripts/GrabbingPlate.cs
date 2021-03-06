using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbingPlate : MonoBehaviour
{
    public GameObject Plate;
    public GameObject Hand;
    public Animator character;
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
        if (Input.GetKey(KeyCode.P))
        {
            Grabbed = Plate;
            Plate.transform.SetParent(Hand.transform);
            Plate.transform.transform.localPosition = new Vector3(0, 0, 0);
            Plate.transform.transform.localEulerAngles = new Vector3(115, 180, -60);
            character.SetBool("HavePlate", true);
        }
    }
}
