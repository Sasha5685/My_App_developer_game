using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControllerCreateGame : MonoBehaviour
{
    public Animator animVariantGame;
    void Start()
    {

        animVariantGame.SetBool("IsClouse", true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClouseVariantCreateGame()
    {
        animVariantGame.SetBool("IsClouse", true);


    }
    public void VariantCreateGame()
    {
        animVariantGame.SetBool("IsClouse", false);
    }
}
