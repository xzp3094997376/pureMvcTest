using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;
public class TestFacade:Facade {
    public TestFacade(GameObject canvas)
    {
        RegisterCommand(NotificationConst.levelUp, typeof(TestCommand));
        RegisterMediator(new TestMediator(canvas));
        RegisterProxy(new TestProxy());
    }
}
