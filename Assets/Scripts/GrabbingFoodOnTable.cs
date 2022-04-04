using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbingFoodOnTable : MonoBehaviour
{
    public GameObject ChoppedTomato;
    public GameObject LeftHand;
    public GameObject RightHand;
    public GameObject text;
    public GameObject Table;
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        text.SetActive(true);

        if (Input.GetKey(KeyCode.T) && RightHand.transform.childCount < 1)
        {
            ChoppedTomato.transform.SetParent(LeftHand.transform);
            ChoppedTomato.transform.transform.localPosition = new Vector3(0.559f, 0.49f, -0.191f);
            ChoppedTomato.transform.transform.eulerAngles = new Vector3(-36.56f, -35.67f, 126.20f);
        }
    }
}
