//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\dotne\source\repos\spectnetide\Assembler\AntlrZ80AsmParserGenerator\ParserGenerator\Z80Asm.g4 by ANTLR 4.6.4

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Spect.Net.Assembler.Generated {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="Z80AsmParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.4")]
[System.CLSCompliant(false)]
public interface IZ80AsmVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompileUnit([NotNull] Z80AsmParser.CompileUnitContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.asmline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAsmline([NotNull] Z80AsmParser.AsmlineContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLabel([NotNull] Z80AsmParser.LabelContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComment([NotNull] Z80AsmParser.CommentContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.pragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPragma([NotNull] Z80AsmParser.PragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirective([NotNull] Z80AsmParser.DirectiveContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] Z80AsmParser.StatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.macroStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMacroStatement([NotNull] Z80AsmParser.MacroStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.macroEndMarker"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMacroEndMarker([NotNull] Z80AsmParser.MacroEndMarkerContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.loopStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLoopStatement([NotNull] Z80AsmParser.LoopStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.loopEndMarker"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLoopEndMarker([NotNull] Z80AsmParser.LoopEndMarkerContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.repeatStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRepeatStatement([NotNull] Z80AsmParser.RepeatStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.untilStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUntilStatement([NotNull] Z80AsmParser.UntilStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileStatement([NotNull] Z80AsmParser.WhileStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.whileEndMarker"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileEndMarker([NotNull] Z80AsmParser.WhileEndMarkerContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStatement([NotNull] Z80AsmParser.IfStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.elifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElifStatement([NotNull] Z80AsmParser.ElifStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.elseStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseStatement([NotNull] Z80AsmParser.ElseStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.endifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEndifStatement([NotNull] Z80AsmParser.EndifStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.macroInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMacroInvocation([NotNull] Z80AsmParser.MacroInvocationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.orgPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrgPragma([NotNull] Z80AsmParser.OrgPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.entPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEntPragma([NotNull] Z80AsmParser.EntPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.xentPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitXentPragma([NotNull] Z80AsmParser.XentPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.dispPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDispPragma([NotNull] Z80AsmParser.DispPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.equPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEquPragma([NotNull] Z80AsmParser.EquPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.varPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarPragma([NotNull] Z80AsmParser.VarPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.defbPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefbPragma([NotNull] Z80AsmParser.DefbPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.defwPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefwPragma([NotNull] Z80AsmParser.DefwPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.defmPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefmPragma([NotNull] Z80AsmParser.DefmPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.skipPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSkipPragma([NotNull] Z80AsmParser.SkipPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.externPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExternPragma([NotNull] Z80AsmParser.ExternPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.defsPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefsPragma([NotNull] Z80AsmParser.DefsPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.fillbPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFillbPragma([NotNull] Z80AsmParser.FillbPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.fillwPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFillwPragma([NotNull] Z80AsmParser.FillwPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.modelPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModelPragma([NotNull] Z80AsmParser.ModelPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.alignPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlignPragma([NotNull] Z80AsmParser.AlignPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.tracePragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTracePragma([NotNull] Z80AsmParser.TracePragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.rndSeedPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRndSeedPragma([NotNull] Z80AsmParser.RndSeedPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.defgPragma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefgPragma([NotNull] Z80AsmParser.DefgPragmaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperation([NotNull] Z80AsmParser.OperationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.trivialOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTrivialOperation([NotNull] Z80AsmParser.TrivialOperationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.compoundOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompoundOperation([NotNull] Z80AsmParser.CompoundOperationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.trivialNextOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTrivialNextOperation([NotNull] Z80AsmParser.TrivialNextOperationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.operand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperand([NotNull] Z80AsmParser.OperandContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.reg8"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReg8([NotNull] Z80AsmParser.Reg8Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.reg8Idx"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReg8Idx([NotNull] Z80AsmParser.Reg8IdxContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.reg8Spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReg8Spec([NotNull] Z80AsmParser.Reg8SpecContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.reg16"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReg16([NotNull] Z80AsmParser.Reg16Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.reg16Idx"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReg16Idx([NotNull] Z80AsmParser.Reg16IdxContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.reg16Spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReg16Spec([NotNull] Z80AsmParser.Reg16SpecContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.regIndirect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRegIndirect([NotNull] Z80AsmParser.RegIndirectContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.cPort"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCPort([NotNull] Z80AsmParser.CPortContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.memIndirect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMemIndirect([NotNull] Z80AsmParser.MemIndirectContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.indexedAddr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIndexedAddr([NotNull] Z80AsmParser.IndexedAddrContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondition([NotNull] Z80AsmParser.ConditionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] Z80AsmParser.ExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.orExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrExpr([NotNull] Z80AsmParser.OrExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.xorExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitXorExpr([NotNull] Z80AsmParser.XorExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.andExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAndExpr([NotNull] Z80AsmParser.AndExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.equExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEquExpr([NotNull] Z80AsmParser.EquExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.relExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelExpr([NotNull] Z80AsmParser.RelExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.shiftExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShiftExpr([NotNull] Z80AsmParser.ShiftExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.addExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddExpr([NotNull] Z80AsmParser.AddExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.multExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultExpr([NotNull] Z80AsmParser.MultExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.unaryExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryExpr([NotNull] Z80AsmParser.UnaryExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.functionInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionInvocation([NotNull] Z80AsmParser.FunctionInvocationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.literalExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralExpr([NotNull] Z80AsmParser.LiteralExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.symbolExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSymbolExpr([NotNull] Z80AsmParser.SymbolExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.macroParam"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMacroParam([NotNull] Z80AsmParser.MacroParamContext context);
}
} // namespace Spect.Net.Assembler.Generated
