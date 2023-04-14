using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TraduccionManager : MonoBehaviour
{
    public static TraduccionManager Instance;

    public Text frase;
    public Text frase1;
    public Text frase2;
    public Text frase3;

    void Awake()
    {
        Instance = this;
    }

    public void SwapText(Scriptableobjects parrafo)
    {
        frase.text = parrafo.texto;
        frase1.text = parrafo.texto1;
        frase2.text = parrafo.texto2;
        frase3.text = parrafo.texto3;

    }


}
