using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] characters;

    public void SetCharacter(int c)
    {
        foreach (var character in characters)
        {
            character.SetActive(false);
        }
        characters[c].SetActive(true);
    }

    public void SetCloth(int c)
    {
        foreach (var character in characters)
        {
            character.GetComponent<CharacterController>().SetCloth(c);
        }
    }

    public void ChangeAnimation()
    {
        foreach (var character in characters)
        {
            character.GetComponent<CharacterController>().ChangeAnimation();
        }
    }
}
