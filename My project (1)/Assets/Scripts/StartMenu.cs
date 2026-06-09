using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public GameObject opening;
    // Start is called before the first frame update
    void Start()
    {
        opening.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {

            opening.SetActive(true);

        }
        else {  opening.SetActive(false); }
    }
}
