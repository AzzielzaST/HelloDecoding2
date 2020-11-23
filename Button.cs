using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    void CobaKlik() 
    {
        // Output ini akan tampil ketika Tombol diklik
        Debug.Log("Dicoding Indonesia");
    }

    void KlikDenganParameter (string message) 
    {
        // Output ini akan tampil ketika Tombol diklik
        Debug.Log(message);
    }
}
