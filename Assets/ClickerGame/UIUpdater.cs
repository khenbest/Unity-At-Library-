using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIUpdater : MonoBehaviour
{
    public Clicker Clicker;

    TextMeshProUGUI textContainer;
    // Start is called before the first frame update
    void Start()
    {
        textContainer = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textContainer.text = $"You've clicked it {Clicker.ClickCount} times";
    }
}



