﻿using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class DbLogger : ILogger
{
    public void LogMessage(string message)
    {
        // Code to write message to database
    }
}