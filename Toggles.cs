using UnityEngine;
using UnityEngine.UI;

public class Toggles : MonoBehaviour
{
    Toggle m_Toggle;
    public Text m_Text;

    void Start()
    {
        // Ambil Toggle GameObject
        m_Toggle = GetComponent<Toggle>();

        // Inisialisasi Teks untuk mengecek apakah Toggle dalam keadaan positif (on) atau negatif (off)
        m_Text.text = "Toggle dalam keadaan: " + m_Toggle.IsOn;
    }
}
