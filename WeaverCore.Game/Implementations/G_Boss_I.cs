﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeaverCore.Implementations;

namespace WeaverCore.Game.Implementations
{
    public class G_Boss_I : Boss_I
    {
        public class G_Statics : Boss_I.Statics
        {
            public override void OnBossesDeadAdd(Action action)
            {
                if (BossSceneController.Instance != null)
                {
                    BossSceneController.Instance.OnBossesDead += action;
                }
            }

            public override void OnBossesDeadRemove(Action action)
            {
                if (BossSceneController.Instance != null)
                {
                    BossSceneController.Instance.OnBossesDead -= action;
                }
            }

            public override void OnBossSceneCompleteAdd(Action action)
            {
                if (BossSceneController.Instance != null)
                {
                    BossSceneController.Instance.OnBossSceneComplete += action;
                }
            }

            public override void OnBossSceneCompleteRemove(Action action)
            {
                if (BossSceneController.Instance != null)
                {
                    BossSceneController.Instance.OnBossSceneComplete -= action;
                }
            }

            public override void EndBossBattle(float delayTime)
            {
                if (BossSceneController.Instance != null)
                {
                    BossSceneController.Instance.bossesDeadWaitTime = delayTime;
                    BossSceneController.Instance.EndBossScene();
                }
            }
        }
    }
}
