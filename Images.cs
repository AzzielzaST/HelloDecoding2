using UnityEngine;
using UnityEngine;

public class Images : MonoBehaviour {
    Image m_Image;

    // Atur pada Inspector
    public Sprite m_Sprite;

    void Start() {
        // Ambil Gambar dari GameObject
        m_Image = GetComponent<Image>();
    }

    void Update() {
        // Tekan spasi untuk mengubah Sprite dari Gambar
        if (Input.GetKey(KeyCode.Space)) {
            m_Image.sprite = m_Sprite;
        }
        
    }
}
