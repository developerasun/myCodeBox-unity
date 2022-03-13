using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class list : MonoBehaviour
{
    // list is a dynamic size of array
    public class BadGuy
    {
        public string name; // class instance variable
        public BadGuy(string _name) // constructor
        {
            name = _name;
        }
    }

    List<BadGuy> badguys = new List<BadGuy>();

    void initBadguys()
    {
        badguys.Add(new BadGuy("Jake"));
        badguys.Add(new BadGuy("Brian"));
        badguys.Add(new BadGuy("Paul"));
    }

    void sortBadguys()
    {
        badguys.Sort();
    }

    void clearBadguys()
    {
        badguys.Clear();
    }
}
