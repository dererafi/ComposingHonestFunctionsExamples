﻿namespace ReportGenerator3
{
    public sealed class Report
    {
        public Report(string value)
        {
            Value = value;
        }

        public string Value { get; }
    }
}