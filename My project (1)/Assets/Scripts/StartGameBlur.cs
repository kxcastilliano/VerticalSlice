using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameBlur : MonoBehaviour
{
    [SerializeField] private Material material;
    private float blurAmount;
    private bool blurActive;
    public GameObject opening;

    private void Start()
    {
        blurAmount = 0;
        opening.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            blurActive = !blurActive;
            opening.SetActive(true);
        }
        float blurSpeed = 10f;
        if (blurActive)
        {
            blurAmount += blurSpeed * Time.deltaTime;
        } else {  blurAmount -= blurSpeed * Time.deltaTime;

            opening.SetActive(false);
        }

        blurAmount = Mathf.Clamp(blurAmount, 0f,0.67f);
        material.SetFloat("_Blur", blurAmount);
    }
}
