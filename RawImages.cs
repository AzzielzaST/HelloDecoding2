using UnityEngine;
using UnityEngine.UI;

public class RawImages : MonoBehaviour {
    RawImages m_RawImage;

    // Pilih Tekstur pada Inspector untuk diubah menjadi gambar
    public Texture m_Texture;

    void Start() 
    {
        // Ambil komponen Raw Image dari GameObject 
        m_RawImage = GetComponent<RawImage>();

        // Ubah Tekstur yang Anda tentukan di Inspector
        m_RawImage.texture = m_Texture;
    }
}
