using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SelectButton : MonoBehaviour
{
    public int level = 0;

    void Start() {
        GetComponent<Button>().interactable = UILevel.Levels[level];
    }
}
