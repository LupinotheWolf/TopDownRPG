using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell
{
    public int id;
    public string name;
    public int requiredMP;
    public bool isLearned;

    public Spell(int _id, string _name, int _requiredMP)
    {
        id = _id;
        name = _name;
        requiredMP = _requiredMP;
    }


}
