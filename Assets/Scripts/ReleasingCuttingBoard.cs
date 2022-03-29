using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleasingCuttingBoard : MonoBehaviour
{
    public GameObject Hand;
    public GameObject CuttingBoard;
    public GameObject Table;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R) && Hand.transform.Find("CuttingBoard"))
        {
            CuttingBoard.transform.SetParent(Table.transform);
            CuttingBoard.transform.transform.position = new Vector3(-14.32f, 1.422f, 26.057f);
            CuttingBoard.transform.transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
