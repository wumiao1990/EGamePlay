﻿using EGamePlay.Combat.Ability;
using System;
using GameUtils;

namespace EGamePlay.Combat.Skill
{
    public abstract class SkillAbility : AbilityEntity
    {
        public SkillConfigObject SkillConfigObject { get; set; }
        public bool Spelling { get; set; }
        public GameTimer CooldownTimer { get; } = new GameTimer(1f);


        public override void Awake(object initData)
        {
            base.Awake(initData);

            SkillConfigObject = initData as SkillConfigObject;
            if (SkillConfigObject.SkillSpellType == SkillSpellType.Passive)
            {
                TryActivateAbility();
            }
        }
    }
}