using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Sliders : MonoBehaviour
{
    public Slider mainSlider;

    // Dipanggil ketika tombol submit di klik 
    public void CobaSlider() 
    {
        // Menampilkan nilai pada console 
        Debug.Log(mainSlider.value);
    }
}
