using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropdowns : MonoBehaviour
{
    // Buat Daftar opsi Dropdown Baru 
    List<string> m_DropOptions = new List<string> ("Opsi 1", "Opsi 2", "Opsi 3");

    // Ini adalah Dropdown;
    Dropdown m_Dropdown;

    void Start()
    {
        // Ambil GameObject Dropdown yang dilampirkan pada script
        m_Dropdown = GetComponent<Dropdown>();

        // Tambahan opsi yang dibuat pada Daftar
        m_Dropdown.AddOptions(m_DropOptions);
    }
}
