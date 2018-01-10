﻿using Antlr4.Runtime;
using Spect.Net.TestParser.SyntaxTree.Expressions;

namespace Spect.Net.TestParser.SyntaxTree.TestSet
{
    public class MemoryAssignment : AssignmentNode
    {
        /// <summary>
        /// Creates a clause with the span defined by the passed context
        /// </summary>
        /// <param name="context">Parser rule context</param>
        public MemoryAssignment(ParserRuleContext context) : base(context)
        {
        }

        /// <summary>
        /// The memory address;
        /// </summary>
        public ExpressionNode Address { get; set; }

        /// <summary>
        /// Memory expression value
        /// </summary>
        public ExpressionNode Value { get; set; }

        /// <summary>
        /// Oprional length value
        /// </summary>
        public ExpressionNode Lenght { get; set; }
    }
}