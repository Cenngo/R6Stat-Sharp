﻿namespace R6Stats.Stats.Interfaces
{
    public interface IPlayerStat
    {
        int Kills { get; }
        int Deaths { get; }
        double KD { get; }
        int Wins { get; }
        int Losses { get; }
        double WinLose { get; }
    }
}
