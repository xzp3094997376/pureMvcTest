using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInfor  {
    public int Level { set; get; }
    public int Hp { set; get; }
    public  CharacterInfor()
    {
    }
    public CharacterInfor(int l,int h)
    {
        Level = l;
        Hp = h;
    }

}
