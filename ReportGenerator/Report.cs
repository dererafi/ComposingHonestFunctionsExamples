﻿namespace ReportGenerator
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