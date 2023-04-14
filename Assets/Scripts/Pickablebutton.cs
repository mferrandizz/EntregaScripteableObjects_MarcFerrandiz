using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickablebutton : MonoBehaviour
{
    public Scriptableobjects traduccion;

    public void Traducir()
    {
        TraduccionManager.Instance.SwapText(traduccion);
    }
}
