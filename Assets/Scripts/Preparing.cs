using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preparing : MonoBehaviour
{

    public GameObject Table;
    public GameObject Plate;
    public GameObject BottomBread;
    public GameObject TopBread;
    public GameObject Tomato;
    public GameObject Cheese;
    public GameObject Steak;
    public GameObject RightHand;
    public GameObject LeftHand;
    public Animator anim;
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
        if (Input.GetKey(KeyCode.R) && RightHand.transform.Find("plate"))
        {
            Plate.transform.SetParent(Table.transform);
            anim.SetBool("HavePlate", false);
            Plate.transform.transform.localEulerAngles = Vector3.zero;
            Plate.transform.transform.localPosition = new Vector3(0.426f , 0.831f, -0.235f);
        }


        if (Input.GetKey(KeyCode.R) && Table.transform.Find("plate") && LeftHand.transform.Find("BottomBread"))
        {
            BottomBread.transform.SetParent(Plate.transform);
            BottomBread.transform.transform.localPosition = new Vector3(0.009f, 0.019f, 0);
            BottomBread.transform.transform.localEulerAngles = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.R) && Plate.transform.Find("BottomBread") && LeftHand.transform.Find("Steak"))
        {
            Steak.transform.SetParent(Plate.transform);
            Steak.transform.transform.localPosition = new Vector3(0.009f, 0.048f, 0);
            Steak.transform.transform.localEulerAngles = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.R) && Plate.transform.Find("Steak") && LeftHand.transform.Find("Cheese"))
        {
            Cheese.transform.SetParent(Plate.transform);
            Cheese.transform.transform.localPosition = new Vector3(0.009f, 0.058f, 0);
            Cheese.transform.transform.localEulerAngles = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.R) && Plate.transform.Find("Cheese") && LeftHand.transform.Find("CutTomato"))
        {
            Tomato.transform.SetParent(Plate.transform);
            Tomato.transform.transform.localPosition = new Vector3(0.009f, 0.061f, 0);
            Tomato.transform.transform.localEulerAngles = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.R) && Plate.transform.Find("CutTomato") && LeftHand.transform.Find("TopBread"))
        {
            TopBread.transform.SetParent(Plate.transform);
            TopBread.transform.transform.localPosition = new Vector3(0.009f, 0.07f, 0);
            TopBread.transform.transform.localEulerAngles = Vector3.zero;
        }
    }
}
