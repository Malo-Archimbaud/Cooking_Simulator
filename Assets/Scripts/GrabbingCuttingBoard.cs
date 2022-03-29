using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbingCuttingBoard : MonoBehaviour
{
    public GameObject Door3;
    public GameObject CuttingBoard;
    public GameObject Hand;
    public GameObject text;
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

        if (Input.GetKey(KeyCode.C))
        {
            CuttingBoard.transform.SetParent(Hand.transform);
            CuttingBoard.transform.transform.localPosition = new Vector3(-0.022f, -1.446f, 1.625f);
            CuttingBoard.transform.transform.localEulerAngles = new Vector3(-131.21f, -6.1170f, 85.74f);
        }
    }
}
