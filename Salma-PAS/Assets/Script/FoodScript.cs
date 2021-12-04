using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{

    public GameObject foodobject;
    public AudioSource sound;
    public GameObject player;
    private int colorIndex;

    // Start is called before the first frame update
    void Start()
    {

        colorIndex = Random.Range(0, 5);
        


        print("Food" + colorIndex);
        switch (colorIndex)
        {
            case 0:
                ChangeColor(Color.blue);
                break;

            case 1:
                ChangeColor(Color.green);
                break;

            case 2:
                ChangeColor(Color.black);
                break;

            case 3:
                ChangeColor(Color.cyan);
                break;

            case 4:
                ChangeColor(Color.red);
                break;

            case 5:
                ChangeColor(Color.magenta);
                break;
        }
         
    }

    private void OnTriggerEnter(Collider other)
    {
        FoodText.foodValue += 5;
        sound.Play();
        player.GetComponent<PlayerController>().ScaleUp();
        Destroy(foodobject);
    }

    public void ChangeColor(Color color)
    {
        var cubeRenderer = foodobject.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", color);
    }

}
