using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scrollbars : MonoBehaviour
{
   public ScrollRect newScrollRect;
   public Scrollbar newScrollBar;
    void Start()
    {
        // Ubah posisi Handle vertikal 
        newScrollRect.verticalNormalizedPosition = 0,5f;
    }
}
