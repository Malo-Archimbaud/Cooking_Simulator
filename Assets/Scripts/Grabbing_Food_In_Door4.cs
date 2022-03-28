using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbing_Food_In_Door4 : MonoBehaviour
{
    public GameObject Door4;
    public GameObject Plate;
    public GameObject Hand;
    public GameObject Bread;
    public GameObject Onion;
    public GameObject Acorn;
    public GameObject Mushroom;
    public GameObject Garllic;
    public GameObject text;
    private GameObject Grabbed;

    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        text.SetActive(true);

        if (Input.GetKey(KeyCode.N))
        {
            Grabbed = Bread;
            Bread.transform.SetParent(Hand.transform);
            Bread.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.V))
        {
            Grabbed = Onion;
            Onion.transform.SetParent(Hand.transform);
            Onion.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.J))
        {
            Grabbed = Acorn;
            Acorn.transform.SetParent(Hand.transform);
            Acorn.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.X))
        {
            Grabbed = Mushroom;
            Mushroom.transform.SetParent(Hand.transform);
            Mushroom.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.I))
        {
            Grabbed = Garllic;
            Garllic.transform.SetParent(Hand.transform);
            Garllic.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
      
    }
}
