using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roles : MonoBehaviour
{
    [SerializeField] protected string _role;
    [SerializeField] protected string _info;
    [SerializeField] protected int _hp;
    [SerializeField] protected int _dmg;
    [SerializeField] protected int _def;
    [SerializeField] protected string _skill;

    public virtual void Info(){
        Debug.Log($"{_role} class - {_info} | {_hp} HP | {_dmg} DMG | {_def} DEF | skill: {_skill}");
    }
}
