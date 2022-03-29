using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleasingKnife : MonoBehaviour
{
    public GameObject Hand;
    public GameObject Knife;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R) && Hand.transform.Find("1kceramicblade"))
        {
            Knife.transform.SetParent(null);
            Knife.transform.transform.position = new Vector3(-14.32f, 1.422f, 25.613f);
            Knife.transform.transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
