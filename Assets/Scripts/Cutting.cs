using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutting : MonoBehaviour
{
    public GameObject Table;
    public GameObject CuttingBoard;
    public GameObject Tomato;
    public GameObject ChoppedTomato;
    public Animator CuttingTomato;
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
        if (Table.transform.Find("CuttingBoard") && CuttingBoard.transform.Find("tomato") && Input.GetKey(KeyCode.T))
        {
            CuttingTomato.SetBool("Tomato", true);
            Tomato.SetActive(false);
            ChoppedTomato.SetActive(true);

        }
    }
}
