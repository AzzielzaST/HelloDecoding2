using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputFields : MonoBehaviour
{
    public InputField mainInputField;

    public void Start()
    {
        mainInputField.text = "Tuliskan teks disini...";
    }
}
