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
        if (Input.GetKey(KeyCode.B))
        {
            Grabbed = Banana;
            Banana.transform.SetParent(Hand.transform);
            Banana.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.C))
        {
            Grabbed = Carrot;
            Carrot.transform.SetParent(Hand.transform);
            Carrot.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.G))
        {
            Grabbed = Eggs;
            Eggs.transform.SetParent(Hand.transform);
            Eggs.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.H))
        {
            Grabbed = Cheese;
            Cheese.transform.SetParent(Hand.transform);
            Cheese.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.K))
        {
            Grabbed = Cake;
            Cake.transform.SetParent(Hand.transform);
            Cake.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.L))
        {
            Grabbed = Lemon;
            Lemon.transform.SetParent(Hand.transform);
            Lemon.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.M))
        {
            Grabbed = Steak;
            Steak.transform.SetParent(Hand.transform);
            Steak.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.O))
        {
            Grabbed = Orange;
            Orange.transform.SetParent(Hand.transform);
            Orange.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.P))
        {
            Grabbed = Pizza;
            Pizza.transform.SetParent(Hand.transform);
            Pizza.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.T))
        {
            Grabbed = Tomato;
            Tomato.transform.SetParent(Hand.transform);
            Tomato.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.U))
        {
            Grabbed = Yogurt;
            Yogurt.transform.SetParent(Hand.transform);
            Yogurt.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Grabbed = Kiwi;
            Kiwi.transform.SetParent(Hand.transform);
            Kiwi.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.Y))
        {
            Grabbed = Cherry;
            Cherry.transform.SetParent(Hand.transform);
            Cherry.transform.transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}
