//Code referenced from tutorial https://www.youtube.com/watch?v=2PKBChN10us&t=621s
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterDatabase : ScriptableObject
{
    public Character[] character;

    public int CharacterCount
    {
        get
        {
            return character.Length;
        }

    }

    public Character GetCharacter(int index)
    {
        return character[index];
    }
}
