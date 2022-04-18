using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour
{
    public Animator animator;
    
    List<GameObject> players;
    List<int> intList = new List<int>{1};
    int[] myLimitedArray = new int[4];
    int[] myUnlimitedArray = {1,2,3} ;
    bool myBool = false;
    // Start is called before the first frame update
    void Start()
    {
        print($"checking typeof : {typeof(bool)}"); // result : System.boolean
        print($"checking bool type : {myBool.GetType()}"); // result : System.boolean
        AnimationSetter("wow", false);
        myLimitedArray[0] = 1; 
        // myUnlimitedArray[3] = 5;

        // Using list as an alternative of array in C#
        for (int i=0; i<3; i++)
        {
            intList.Add(i);
        }
        UnityEngine.Debug.Log($"total count of list is : {intList.Count}");

        // find game objects with player tag
        players = GameObject.FindGameObjectsWithTag("Player").ToList();

        for (int j=0; j< players.Count; j++) 
        {
            UnityEngine.Debug.Log($"{j}th's player name : {players[j].name}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // generic function
    void AnimationSetter<T>(string _name, T _condition)  {
        // execute animator.SetBool or  animator.SetInteger based on condition
        if (_condition.GetType() == typeof(bool)) {
            // if T is boolean => string => bool
            print("애니메이션 조건 : bool");
            animator.SetBool(_name, bool.Parse(_condition.ToString()));
        }
        if (_condition.GetType() == typeof(int)) {
            // if T is int => string => int
            print("애니메이션 조건 : int");
            animator.SetInteger(_name, (int.Parse(_condition.ToString())));
        }
    }
    
}
