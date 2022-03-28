using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbing_Food_In_Door6 : MonoBehaviour
{
    public GameObject Door6;
    public GameObject Plate;
    public GameObject Hand;
    public GameObject Waffle;
    public GameObject TopBread;
    public GameObject BottomBread;
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

        if (Input.GetKey(KeyCode.F))
        {
            Grabbed = Waffle;
            Waffle.transform.SetParent(Hand.transform);
            Waffle.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.T))
        {
            Grabbed = TopBread;
            TopBread.transform.SetParent(Hand.transform);
            TopBread.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.B))
        {
            Grabbed = BottomBread;
            BottomBread.transform.SetParent(Hand.transform);
            BottomBread.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}
