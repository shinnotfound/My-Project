using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    public Roles[] Roles;

    private void Start() { 
        foreach (var role in Roles)
        {
            role.Info();
        }
    }
}
