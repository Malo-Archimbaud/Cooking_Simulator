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
    private GameObject Grabbed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R) && Hand.transform.childCount > 0)
        {
            Grabbed.transform.SetParent(null);
            Grabbed = null;
        }
    }

    private void OnTriggerStay(Collider other)
    {

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
