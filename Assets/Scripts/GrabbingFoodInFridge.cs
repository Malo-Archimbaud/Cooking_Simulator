using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbingFoodInFridge : MonoBehaviour
{
    public GameObject Fridge;
    public GameObject Plate;
    public GameObject Hand;
    public GameObject Apple;
    public GameObject Carrot;
    public GameObject Tomato;
    public GameObject Pizza;
    public GameObject Cake;
    public GameObject Kiwi;
    public GameObject Orange;
    public GameObject Yogurt;
    public GameObject Banana;
    public GameObject Cherry;
    public GameObject Eggs;
    public GameObject Lemon;
    public GameObject Steak;
    public GameObject Cheese;
    private GameObject Grabbed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            Grabbed.transform.SetParent(null);
            Grabbed = null;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.A))
        {
            Grabbed = Apple;
            Apple.transform.SetParent(Hand.transform);
            Apple.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}
