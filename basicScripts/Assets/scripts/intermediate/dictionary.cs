using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dictionary : MonoBehaviour
{
    // dictionary is a key value pair
    Dictionary<string, list.BadGuy> badGuys = new Dictionary<string, list.BadGuy>();

    void addBadguys()
    {
        badGuys.Add("Cool gang", new list.BadGuy("Jake"));
        badGuys.Add("hot gang", new list.BadGuy("Paul"));
        badGuys.Add("awesome gang", new list.BadGuy("Brian"));
    }
}
