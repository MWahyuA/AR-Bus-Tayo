using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup : MonoBehaviour
{
    public GameObject Popup;
    // Start is called before the first frame update
   public void OnActive()
    {
        Popup.SetActive(true);
    }

     public void OffActive()
    {
        Popup.SetActive(false);
    }
}
