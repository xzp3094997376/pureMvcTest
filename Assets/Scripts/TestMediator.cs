using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;
using UnityEngine.UI;
using PureMVC.Interfaces;

public class TestMediator : Mediator {
    public new const string NAME = "TestMedaitor";
    private Text levelText;
    private Button levelUpButton;
    public TestMediator(GameObject root):base(NAME)
    {
        levelText = GameUtility.GetChildComponent<Text>(root, "Text/LevelText");
        levelUpButton = GameUtility.GetChildComponent<Button>(root, "levelUpButton");
        levelUpButton.onClick.AddListener(OnClickLevelUpbutton);
    }

    private void OnClickLevelUpbutton()
    {
        SendNotification(NotificationConst.levelUp);
    }
    public override IList<string> ListNotificationInterests()
    {
        IList<string> list = new List<string>();
        list.Add(NotificationConst.levelChange);
        return list;
    }

    public override void HandleNotification(INotification notification)
    {
        switch (notification.Name)
        {
            case NotificationConst.levelChange:
                CharacterInfor ci = notification.Body as CharacterInfor;
                levelText.text = ci.Level.ToString();
                break;
            default:
                break;
        }
    }
}
