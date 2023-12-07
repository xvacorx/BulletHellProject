using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCanva : MonoBehaviour
{
    public GameObject canvatoDisable;
    public GameObject canvatoEnable;

    public void ChangeCanvaOnClick()
    {
        canvatoDisable.SetActive(false);
        canvatoEnable.SetActive(true);
    }
}
