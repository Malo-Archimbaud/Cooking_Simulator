using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingSteak : MonoBehaviour
{
    public GameObject Hand;
    public GameObject Particle;
    public GameObject Pan;
    private GameObject Food;
    // Start is called before the first frame update
    void Start()
    {
        Particle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Hand.transform.childCount > 0)
            Food = Hand.transform.GetChild(0).gameObject;

        if (Pan.transform.childCount > 1)
            Particle.SetActive(true);
        else
            Particle.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Hand.transform.childCount > 0 && Input.GetKey(KeyCode.P))
        {
            Food.transform.SetParent(Pan.transform);
            Food.transform.transform.localPosition = new Vector3(-0.005f, 0.0196f, 0.0163f);
            Food.transform.transform.localEulerAngles = new Vector3(0, 0, 0);
        }

        if (Pan.transform.childCount > 1 && Input.GetKey(KeyCode.R))
        {
            Food.transform.SetParent(Hand.transform);
            Food.transform.transform.localPosition = new Vector3(0,0,0);
        }
    }
}
