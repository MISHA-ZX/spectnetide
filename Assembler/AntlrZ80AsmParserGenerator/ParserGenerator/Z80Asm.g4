grammar Z80Asm;

/*
 * Parser Rules
 */

compileUnit	
	:	EOF
	|	NEWLINE* asmline (NEWLINE+ asmline)* NEWLINE* EOF
	;

asmline
	:	label? (pragma | operation | macroParam | statement | macroInvocation) comment?
	|	directive comment?
	|	comment
	|   label comment?
	;

label
	:	IDENTIFIER COLON?
	;

comment
	:	COMMENT
	;

pragma
	:	orgPragma
	|	entPragma
	|	xentPragma
	|	dispPragma
	|	equPragma
	|	varPragma
	|	defbPragma
	|	defwPragma
	|	defmPragma
	|	skipPragma
	|	externPragma
	|	defsPragma
	|	fillbPragma
	|	fillwPragma
	|	modelPragma
	|	alignPragma
	|	tracePragma
	|	rndSeedPragma
	|	defgPragma
	;

directive
	:	(IFDEF|IFNDEF|DEFINE|UNDEF|IFMOD|IFNMOD) IDENTIFIER
	|	ENDIF
	|	ELSE
	|	IF expr
	|	INCLUDE (STRING | FSTRING)
	;	

statement
	:	macroStatement
	|	macroEndMarker
	|	loopStatement
	|	loopEndMarker
	|	repeatStatement
	|	untilStatement
	|	whileStatement
	|	whileEndMarker
	|	ifStatement
	|	elifStatement
	|	elseStatement
	|	endifStatement
	|	forStatement
	|	nextStatement
	;

macroStatement: MACRO LPAR (IDENTIFIER (COMMA IDENTIFIER)*)? RPAR	;
macroEndMarker: ENDMACRO ;
loopStatement: LOOP expr ;
loopEndMarker: ENDLOOP ;
repeatStatement: REPEAT ;
untilStatement: UNTIL expr ;
whileStatement: WHILE expr ;
whileEndMarker: ENDWHILE ;
ifStatement: IFSTMT expr ;
elifStatement: ELIF expr ;
elseStatement: ELSESTMT ;
endifStatement: ENDIFSTMT ;
forStatement: FOR IDENTIFIER ASSIGN expr TO expr (STEP expr)? ;
nextStatement: (NEXT | FORNEXT) ;

macroInvocation: IDENTIFIER LPAR (expr (COMMA expr)*)? RPAR	;

orgPragma	: ORGPRAG expr ;
entPragma	: ENTPRAG expr ;
xentPragma	: XENTPRAG expr ;
dispPragma	: DISPRAG expr ;
equPragma	: EQUPRAG expr ;
varPragma	: (VARPRAG | ASSIGN) expr ;
defbPragma	: DBPRAG expr (COMMA expr)* ;
defwPragma	: DWPRAG expr (COMMA expr)* ;
defmPragma	: DMPRAG expr ;
skipPragma	: SKIPRAG expr (COMMA expr)?;
externPragma: EXTPRAG ;
defsPragma	: DSPRAG expr ;
fillbPragma	: FBPRAG expr COMMA expr ;
fillwPragma : FWPRAG expr COMMA expr ;
modelPragma : MODPRAG (IDENTIFIER | NEXT) ;
alignPragma : ALGPRAG expr? ;
tracePragma : (TRACE | TRACEHEX) expr ( ',' expr)* ;
rndSeedPragma: RNDSEED expr? ;
defgPragma	: DGPRAG expr ;

operation
	:	trivialOperation
	|	compoundOperation
	|	trivialNextOperation
	;

trivialOperation
	:	NOP
	|	RLCA
	|	RRCA
	|	RLA
	|	RRA
	|	DAA
	|	CPL
	|	SCF
	|	CCF
	|	HALT
	|	EXX
	|	DI
	|	EI
	|	NEG
	|	RETN
	|	RETI
	|	RLD
	|	RRD
	|	LDI
	|	CPI
	|	INI
	|	OUTI
	|	LDD
	|	CPD
	|	IND
	|	OUTD
	|	LDIR
	|	CPIR
	|	INIR
	|	OTIR
	|	LDDR
	|	CPDR
	|	INDR
	|	OTDR
	;

compoundOperation
	:	LD operand COMMA operand
	|	INC operand
	|	DEC operand
	|	EX operand COMMA operand
	|	ADD operand COMMA operand
	|	ADC operand COMMA operand
	|	SUB (operand COMMA)? operand
	|	SBC operand COMMA operand
	|	AND (operand COMMA)? operand
	|	XOR (operand COMMA)? operand
	|	OR (operand COMMA)? operand
	|	CP (operand COMMA)? operand
	|	DJNZ operand
	|	JR (condition COMMA)? operand
	|	JP (condition COMMA)? operand
	|	CALL (condition COMMA)? operand
	|	RET condition?
	|	RST operand
	|	PUSH operand
	|	POP operand
	|	IN (operand COMMA)? operand
	|	OUT (operand COMMA)? operand
	|	IM operand
	|	RLC (operand COMMA)? operand
	|	RRC (operand COMMA)? operand
	|	RL (operand COMMA)? operand
	|	RR (operand COMMA)? operand
	|	SLA (operand COMMA)? operand
	|	SRA (operand COMMA)? operand
	|	SLL (operand COMMA)? operand
	|	SRL (operand COMMA)? operand
	|	BIT expr COMMA operand
	|	RES expr COMMA (operand COMMA)? operand
	|	SET expr COMMA (operand COMMA)? operand
	// --- Next operation
	|	MIRROR operand
	|	TEST operand
	|	NEXTREG operand COMMA operand
	;

trivialNextOperation
	:	SWAPNIB
	|	MUL
	|	OUTINB
	|	LDIX
	|	LDIRX
	|	LDDX
	|	LDDRX
	|	PIXELDN
	|	PIXELAD
	|	SETAE
	|	LDPIRX
	|	LDIRSCALE
	;

// --- Operands
operand
	:	reg8
	|	reg8Idx
	|	reg8Spec
	|	reg16
	|	reg16Idx
	|	reg16Spec
	|	regIndirect
	|	cPort
	|	memIndirect
	|	indexedAddr
	|	expr
	|	condition
	;

reg8
	:	'a'|'A'
	|	'b'|'B'
	|	'c'|'C'
	|	'd'|'D'
	|	'e'|'E'
	|	'h'|'H'
	|	'l'|'L'
	;

reg8Idx
	:	'xl'|'XL'
	|	'xh'|'XH'
	|	'yl'|'YL'
	|	'yh'|'YH'
	|	'ixl'|'IXL'|'IXl'
	|	'ixh'|'IXH'|'IXh'
	|	'iyl'|'IYL'|'IYl'
	|	'iyh'|'IYH'|'IYh'
	;

reg8Spec
	:	'i'|'I'
	|	'r'|'R'
	;

reg16
	:	'bc'|'BC'
	|	'de'|'DE'
	|	'hl'|'HL'
	|	'sp'|'SP'
	;

reg16Idx
	:	'ix'|'IX'
	|	'iy'|'IY'
	;

reg16Spec
	:	'af\''|'AF\''
	|	'af'|'AF'
	;

regIndirect
	:	LPAR (reg16) RPAR
	;

cPort
	:	LPAR ('c'|'C') RPAR
	;

memIndirect
	:	LPAR expr RPAR
	;

indexedAddr
	:	LPAR reg16Idx ((PLUS | MINUS) expr)? RPAR
	;

condition
	:	'z'|'Z'
	|	'nz'|'NZ'
	|	'c'|'C'
	|	'nc'|'NC'
	|	'po'|'PO'
	|	'pe'|'PE'
	|	'p'|'P'
	|	'm'|'M'
	;

// --- Expressions
expr
	: orExpr (QMARK expr COLON expr)?
	; 

orExpr
	: xorExpr (VBAR xorExpr)*
	;

xorExpr
	: andExpr (UPARR andExpr)*
	;

andExpr
	: equExpr (AMP equExpr)*
	;

equExpr
	: relExpr ((EQOP | NEQOP) relExpr)*
	;

relExpr
	: shiftExpr ((LTOP | LTEOP | GTOP | GTEOP) shiftExpr)*
	;

shiftExpr
	: addExpr ((LSHOP | RSHOP) addExpr)*
	;

addExpr
	: multExpr ((PLUS | MINUS ) multExpr)*
	;

multExpr
	: unaryExpr ((MULOP | DIVOP | MODOP) unaryExpr)*
	;

unaryExpr
	: functionInvocation
	| macroParam
	| PLUS unaryExpr
	| MINUS unaryExpr
	| TILDE unaryExpr
	| LSBRAC expr RSBRAC
	| LPAR expr RPAR
	| literalExpr
	| symbolExpr
	;

functionInvocation
	: IDENTIFIER LPAR RPAR
	| IDENTIFIER LPAR expr (COMMA expr)* RPAR
	;

literalExpr
	: HEXNUM 
	| DECNUM 
	| CHAR
	| BINNUM
	| REALNUM
	| BOOLLIT
	| STRING
	| CURADDR
	| CURCNT
	;

symbolExpr
	: IDENTIFIER
	;

macroParam
	: '{{' IDENTIFIER '}}'
	;

/*
 * Lexer Rules
 */

COMMENT
	:	SCOLON ~('\r' | '\n')*
	;

WS
	:	('\u0020' | '\t') -> channel(HIDDEN)
	;

NEWLINE
	:	('\r'? '\n' | '\r')+
	;

// --- Common tokens
// --- Other tokens
COLON	: ':' ;
SCOLON	: ';' ;
COMMA	: ',' ;
ASSIGN	: '=' ;
LPAR	: '(' ;
RPAR	: ')' ;
LSBRAC	: '[' ;
RSBRAC	: ']' ;
QMARK	: '?' ;
PLUS	: '+' ;
MINUS	: '-' ;
VBAR	: '|' ;
UPARR	: '^' ;
AMP		: '&' ;
EQOP	: '==' ;
NEQOP	: '!=' ;
LTOP	: '<' ;
LTEOP	: '<=' ;
GTOP	: '>' ;
GTEOP	: '>=' ;
LSHOP	: '<<' ;
RSHOP	: '>>' ;
MULOP	: '*' ;
DIVOP	: '/' ;
MODOP	: '%' ;
TILDE	: '~';

// --- Trivial instruction tokens

NOP		: 'nop'|'NOP' ;
RLCA	: 'rlca'|'RLCA' ;
RRCA	: 'rrca'|'RRCA' ;
RLA		: 'rla'|'RLA' ;
RRA		: 'rra'|'RRA' ;
DAA		: 'daa'|'DAA' ;
CPL		: 'cpl'|'CPL' ;
SCF		: 'scf'|'SCF' ;
CCF		: 'ccf'|'CCF' ;
HALT	: 'halt'|'HALT' ;
RET		: 'ret'|'RET' ;
EXX		: 'exx'|'EXX' ;
DI		: 'di'|'DI' ;
EI		: 'ei'|'EI' ;
NEG		: 'neg'|'NEG' ;
RETN	: 'retn'|'RETN' ;
RETI	: 'reti'|'RETI' ;
RLD		: 'rld'|'RLD' ;
RRD		: 'rrd'|'RRD' ;
LDI		: 'ldi'|'LDI' ;
CPI		: 'cpi'|'CPI' ;
INI		: 'ini'|'INI' ;
OUTI	: 'outi'|'OUTI' ;
LDD		: 'ldd'|'LDD' ;
CPD		: 'cpd'|'CPD' ;
IND		: 'ind'|'IND' ;
OUTD	: 'outd'|'OUTD' ;
LDIR	: 'ldir'|'LDIR' ;
CPIR	: 'cpir'|'CPIR' ;
INIR	: 'inir'|'INIR' ;
OTIR	: 'otir'|'OTIR' ;
LDDR	: 'lddr'|'LDDR' ;
CPDR	: 'cpdr'|'CPDR' ;
INDR	: 'indr'|'INDR' ;
OTDR	: 'otdr'|'OTDR' ;

// --- Other instruction tokens
LD		: 'ld'|'LD' ;
INC		: 'inc'|'INC' ;
DEC		: 'dec'|'DEC' ;
EX		: 'ex'|'EX' ;
ADD		: 'add'|'ADD' ;
ADC		: 'adc'|'ADC' ;
SUB		: 'sub'|'SUB' ;
SBC		: 'sbc'|'SBC' ;
AND		: 'and'|'AND' ;
XOR		: 'xor'|'XOR' ;
OR		: 'or'|'OR' ;
CP		: 'cp'|'CP' ;
DJNZ	: 'djnz'|'DJNZ' ;
JR		: 'jr'|'JR' ;
JP		: 'jp'|'JP' ;
CALL	: 'call'|'CALL' ;
RST		: 'rst'|'RST' ;
PUSH	: 'push'|'PUSH' ;
POP		: 'pop'|'POP' ;
IN		: 'in'|'IN' ;
OUT		: 'out'|'OUT' ;
IM		: 'im'|'IM' ;
RLC		: 'rlc'|'RLC' ;
RRC		: 'rrc'|'RRC' ;
RL		: 'rl'|'RL' ;
RR		: 'rr'|'RR' ;
SLA		: 'sla'|'SLA' ;
SRA		: 'sra'|'SRA' ;
SLL		: 'sll'|'SLL' ;
SRL		: 'srl'|'SRL' ;
BIT		: 'bit'|'BIT' ;
RES		: 'res'|'RES' ;
SET		: 'set'|'SET' ;

// --- Next instruction tokens
SWAPNIB	: 'swapnib'|'SWAPNIB' ;
MUL		: 'mul'|'MUL' ;
POPX	: 'popx'|'POPX' ;
MIRROR	: 'mirror'|'MIRROR' ;
TEST	: 'test'|'TEST' ;
NEXTREG	: 'nextreg'|'NEXTREG' ;
OUTINB	: 'outinb'|'OUTINB' ;
LDIX	: 'ldix'|'LDIX' ;
LDIRX	: 'ldirx'|'LDIRX' ;
LDDX	: 'lddx'|'LDDX' ;
LDDRX	: 'lddrx'|'LDDRX' ;
PIXELDN	: 'pixeldn'|'PIXELDN' ;
PIXELAD	: 'pixelad'|'PIXELAD' ;
SETAE	: 'setae'|'SETAE' ;
LDPIRX	: 'ldpirx'|'LDPIRX' ;
LDIRSCALE: 'ldirscale'|'LDIRSCALE' ;

// --- Pre-processor tokens
IFDEF	: '#ifdef' ;
IFNDEF	: '#ifndef' ;
ENDIF	: '#endif' ;
ELSE	: '#else' ;
DEFINE	: '#define' ;
UNDEF	: '#undef' ;
INCLUDE	: '#include' ;
IF		: '#if' ;
IFMOD	: '#ifmod' ;
IFNMOD	: '#ifnmod' ;

// --- Pragma tokens
ORGPRAG	: '.org' | '.ORG' | 'org' | 'ORG' ;
ENTPRAG	: '.ent' | '.ENT' | 'ent' | 'ENT' ;
XENTPRAG: '.xent' | '.XENT' | 'xent' | 'XENT' ;
EQUPRAG	: '.equ' | '.EQU' | 'equ' | 'EQU' ;
VARPRAG	: '.var' | '.VAR' | 'var' | 'VAR' | ':=' ;
DISPRAG	: '.disp' | '.DISP' | 'disp' | 'DISP' ;
DBPRAG	: '.defb' | '.DEFB' | 'defb' | 'DEFB' | 'db' | '.db' | 'DB' | '.DB' ;
DWPRAG	: '.defw' | '.DEFW' | 'defw' | 'DEFW' | 'dw' | '.dw' | 'DW' | '.DW' ;
DMPRAG	: '.defm' | '.DEFM' | 'defm' | 'DEFM' | 'dm' | '.dm' | 'DM' | '.DM' ;
SKIPRAG	: '.skip' | '.SKIP' | 'skip' | 'SKIP' ;
EXTPRAG : '.extern'|'.EXTERN'|'extern'|'EXTERN' ;
DSPRAG	: '.defs' | '.DEFS' | 'defs' | 'DEFS' ;
FBPRAG	: '.fillb' | '.FILLB' | 'fillb' | 'FILLB' ;
FWPRAG	: '.fillw' | '.FILLW' | 'fillw' | 'FILLW' ;
MODPRAG : '.model' | '.MODEL' | 'model' | 'MODEL' ;
ALGPRAG	: '.align' | '.ALIGN' | 'align' | 'ALIGN' ;
TRACE	: '.trace' | '.TRACE' | 'trace' | 'TRACE' ;
TRACEHEX: '.tracehex' | '.TRACEHEX' | 'tracehex' | 'TRACEHEX' ;
RNDSEED	: '.rndseed' | 'rndseed' | '.RNDSEED' | 'RNDSEED' ;
DGPRAG	: '.defg' | '.DEFG' | 'defg' | 'DEFG' | 'dg' | '.dg' | 'DG' | '.DG' ;

// --- Compiler statements
MACRO	: '.macro' | '.MACRO' | 'macro' | 'MACRO' ;
ENDMACRO: '.endm' | '.ENDM' | 'endm' | 'ENDM' | '.mend' | '.MEND' | 'mend' | 'MEND' ;
LOOP	: '.loop' | '.LOOP' | 'loop' | 'LOOP' ;
ENDLOOP	: '.endl' | '.ENDL' | 'endl' | 'ENDL' | '.lend' | '.LEND' | 'lend' | 'LEND' ;
REPEAT	: '.repeat' | '.REPEAT' | 'repeat' | 'REPEAT' ;
UNTIL	: '.until' | '.UNTIL' | 'until' | 'UNTIL' ;
WHILE	: '.while' | '.WHILE' | 'while' | 'WHILE' ;
ENDWHILE: '.endw' | '.ENDW' | 'endw' | 'ENDW' | '.wend' | '.WEND' | 'wend' | 'WEND' ;
IFSTMT	: '.if' | '.IF' | 'if' | 'IF' ;
ELIF	: '.elif' | '.ELIF' | 'elif' | 'ELIF' ;
ELSESTMT: '.else' | '.ELSE' | 'else' | 'ELSE' ;
ENDIFSTMT: '.endif' | '.ENDIF' | 'endif' | 'ENDIF' ;
FOR		: '.for' | '.FOR' | 'for' | 'FOR' ;
TO		: '.to' | '.TO' | 'to' | 'TO' ;
STEP	: '.step' | '.STEP' | 'step' | 'STEP' ;
FORNEXT	: '.next' | '.NEXT' ;
NEXT	: 'next' | 'NEXT' ;

// --- Basic literals
HEXNUM	: ('#'|'0x'|'$') HexDigit HexDigit? HexDigit? HexDigit?
		| Digit HexDigit? HexDigit? HexDigit? HexDigit? ('H' | 'h') ;
BINNUM	: ('%'| ('0b' '_'?)) BinDigit BinDigit? BinDigit? BinDigit?
		  BinDigit? BinDigit? BinDigit? BinDigit?
		  BinDigit? BinDigit? BinDigit? BinDigit?
		  BinDigit? BinDigit? BinDigit? BinDigit?
		;
DECNUM	: Digit Digit? Digit? Digit? Digit?;

REALNUM	: [0-9]* '.' [0-9]+ ExponentPart? 
		| [0-9]+ ExponentPart;

CHAR	: '\'' (~["\\\r\n\u0085\u2028\u2029] | CommonCharacter) '\'' ;
STRING	: '"'  (~["\\\r\n\u0085\u2028\u2029] | CommonCharacter)* '"' ;
FSTRING	: '<'  (~["\\\r\n\u0085\u2028\u2029] | CommonCharacter)* '>' ;

// --- Boolean literals;

BOOLLIT	: TRUE | FALSE ;
TRUE	: 'true' | '.true' | 'TRUE' | '.TRUE' ;
FALSE	: 'false' | '.false' | 'FALSE' | '.FALSE' ;

// --- Identifiers
IDENTIFIER: IDSTART IDCONT*	;
IDSTART	: '_' | 'A'..'Z' | 'a'..'z'	;
IDCONT	: '_' | '0'..'9' | 'A'..'Z' | 'a'..'z' ;

CURADDR	: '$' | '.' ;
CURCNT	: '$cnt' | '$CNT' | '.cnt' | '.CNT' ;

// --- Any invalid charecter should be converted into an ErrorCharacter token.
ErrorCharacter
    :   .
    ;

fragment CommonCharacter
	: SimpleEscapeSequence
	| HexEscapeSequence
	;

fragment SimpleEscapeSequence
	: '\\i'
	| '\\p'
	| '\\f'
	| '\\b'
	| '\\I'
	| '\\o'
	| '\\a'
	| '\\t'
	| '\\P'
	| '\\C'
	| '\\\''
	| '\\"'
	| '\\\\'
	| '\\0'
	;

fragment HexEscapeSequence
	: '\\x' HexDigit
	| '\\x' HexDigit HexDigit
	;

fragment HexDigit 
	: [0-9] 
	| [A-F] 
	| [a-f]
	;

fragment Digit 
	: '0'..'9' 
	;

fragment BinDigit
	: ('0'|'1') '_'?
	;

fragment ExponentPart
	: [eE] (PLUS | MINUS)? [0-9]+
	;

