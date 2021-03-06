﻿using System.Collections.Generic;
using GraphQL.Instrumentation;
using GraphQL.Language.AST;
using Newtonsoft.Json;

namespace GraphQL
{
    [JsonConverter(typeof(ExecutionResultJsonConverter))]
    public class ExecutionResult
    {
        public object Data { get; set; }

        public ExecutionErrors Errors { get; set; }

        public Dictionary<string, object> Extra { get; private set; } =
            new Dictionary<string, object>();

        public string Query { get; set; }

        public Document Document { get; set; }

        public Operation Operation { get; set; }

        public PerfRecord[] Perf { get; set; }

        public bool ExposeExceptions { get; set; }
    }
}
