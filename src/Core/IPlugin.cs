﻿namespace Core;

public interface IPlugin
{
    string Name { get; }
    void Execute();
}