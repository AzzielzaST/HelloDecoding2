using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Texts : MonoBehaviour
{
    public static int score;

    Text text;

    void Awake()
    {
        // Mengatur reference teks
        text = GetComponent <Text> ();

        // Mengembalikan nilai awal skor
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Jumlah skor yang ditampilkan 
        text.text = "Score: " + score;
    }
}
