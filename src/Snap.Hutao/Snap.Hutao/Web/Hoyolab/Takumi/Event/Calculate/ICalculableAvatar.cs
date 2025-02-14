﻿// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

using Snap.Hutao.Model.Primitive;

namespace Snap.Hutao.Web.Hoyolab.Takumi.Event.Calculate;

/// <summary>
/// 可计算的角色
/// </summary>
public interface ICalculableAvatar : ICalculable
{
    /// <summary>
    /// 角色Id
    /// </summary>
    AvatarId AvatarId { get; }

    /// <summary>
    /// 最小等级
    /// </summary>
    int LevelMin { get; }

    /// <summary>
    /// 最大等级
    /// </summary>
    int LevelMax { get; }

    /// <summary>
    /// 技能组
    /// </summary>
    IList<ICalculableSkill> Skills { get; }
}