﻿using System;
using System.Text;
using Antlr.Runtime.Tree;
using IronJS.Tools;

#if CLR2
using Microsoft.Scripting.Ast;
#else
using System.Linq.Expressions;
#endif

namespace IronJS.Compiler.Ast
{
    using Et = Expression;
    using System.Collections.Generic;

    public class Return : Node
    {
        public INode Value { get; protected set; }
        public Function FuncNode { get; protected set; }

        public Return(INode value, ITree node)
            : base(NodeType.Return, node)
        {
            Value = value;
        }

        public override INode Analyze(Stack<Function> func)
        {
            Value = Value.Analyze(func);
            return this;
        }
    }
}
