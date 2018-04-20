using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;
public class TestProxy : Proxy {
    public new const string NAME = "TestProxy";
    public CharacterInfor Data { get; set; }
    public TestProxy():base(NAME)//
    {
        Data = new CharacterInfor();
    }
    public void ChangeLevel(int change)
    {
        Data.Level += change;
        SendNotification(NotificationConst.levelChange, Data);
    }
}
