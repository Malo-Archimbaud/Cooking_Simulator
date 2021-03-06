using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutting : MonoBehaviour
{
    public GameObject Table;
    public GameObject CuttingBoard;
    public GameObject Tomato;
    public GameObject ChoppedTomato;
    public GameObject Hand;
    public Animator CuttingTomato;
    // Start is called before the first frame update
    void Start()
    {
        ChoppedTomato.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Setfalse ()
    {
        CuttingTomato.SetBool("Tomato", false);

    }

    private void OnTriggerStay(Collider other)
    {
        if (Table.transform.Find("CuttingBoard") && CuttingBoard.transform.Find("tomato") && Input.GetKey(KeyCode.T) && Hand.transform.Find("1kceramicblade"))
        {
            CuttingTomato.SetBool("Tomato", true);
            Tomato.SetActive(false);
            ChoppedTomato.SetActive(true);
            ChoppedTomato.transform.SetParent(Table.transform, false);
            ChoppedTomato.transform.transform.localPosition = new Vector3(-0.758f, 0.915f, -0.268f);
            Tomato.transform.SetParent(null);

            Invoke("Setfalse", 3.0f);
        }
    }
}
