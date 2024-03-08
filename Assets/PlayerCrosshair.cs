using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrosshair : MonoBehaviour
{
    [SerializeField] private Color crosshairColour;
    private GameObject crosshair;
    // Start is called before the first frame update
    void Start()
    {
        crosshair = Instantiate(Resources.Load<GameObject>("Prefabs/Crosshairs/Crosshair"));
        crosshair.GetComponent<SpriteRenderer>().color = crosshairColour;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ShowCrosshair(){
        crosshair.SetActive(true);
        Cursor.visible = false;
    }

    public void HideCrosshair(){
        Cursor.visible = true;
        crosshair.SetActive(false);
    }
}
