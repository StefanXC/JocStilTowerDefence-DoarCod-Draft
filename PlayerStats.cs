using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public static int bani;
    public int baniStart = 100;

    public TextMeshProUGUI baniTXT;

    public static int vieti;

    void Start()
    {
        bani = baniStart;

        baniTXT.text = bani.ToString();
    }

    void Update()
    {
        baniTXT.text = bani.ToString();
    }


    public void BaniUI()//de incercat de apelat din alte scripturi
    {
        baniTXT.text = bani.ToString();
    }
}
