using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonScript : MonoBehaviour
{
    public GameObject BotonGO;
    private void OnMouseDown()
    {
        BotonGO.SetActive(false);
    }
    private void OnMouseUp()
    {
        BotonGO.SetActive(true);
    }
}
