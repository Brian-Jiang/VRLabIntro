using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {
    public Text healthText;

    private int health;
    private int width;
    private int height;

    public void Hello() {
        Debug.Log("Hello!");
    }

    public void SetWidth(int width) {
        this.width = width;
    }
    
    public void Setheight(int height) {
        this.height = height;
    }
    
    public void SetRes() {
        Screen.SetResolution(width, height, false);
    }
    // Start is called before the first frame update
    void Start() {
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            --health;
        }

        healthText.text = health.ToString();
    }
}
