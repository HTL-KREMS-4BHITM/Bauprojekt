﻿namespace Bauprojekt.Interfaces;

public interface IProjectComponent
{
    public string Name { get; set; }
    public string GetDetails();

}