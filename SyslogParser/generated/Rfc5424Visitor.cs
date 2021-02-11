//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Stefan.Steiger\Documents\Visual Studio 2017\Projects\SqlParser\SqlParser\grammars\Rfc5424.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace SyslogServer.grammars {

//CHECKSTYLE:OFF
/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="Rfc5424Parser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IRfc5424Visitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>msgUTF8</c>
	/// labeled alternative in <see cref="Rfc5424Parser.msg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMsgUTF8([NotNull] Rfc5424Parser.MsgUTF8Context context);

	/// <summary>
	/// Visit a parse tree produced by the <c>msgAny</c>
	/// labeled alternative in <see cref="Rfc5424Parser.msg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMsgAny([NotNull] Rfc5424Parser.MsgAnyContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>paramValue</c>
	/// labeled alternative in <see cref="Rfc5424Parser.param_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParamValue([NotNull] Rfc5424Parser.ParamValueContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>headerPriorityValue</c>
	/// labeled alternative in <see cref="Rfc5424Parser.prival"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeaderPriorityValue([NotNull] Rfc5424Parser.HeaderPriorityValueContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>headerHostName</c>
	/// labeled alternative in <see cref="Rfc5424Parser.hostname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeaderHostName([NotNull] Rfc5424Parser.HeaderHostNameContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>headerNilHostName</c>
	/// labeled alternative in <see cref="Rfc5424Parser.hostname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeaderNilHostName([NotNull] Rfc5424Parser.HeaderNilHostNameContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>sdParam</c>
	/// labeled alternative in <see cref="Rfc5424Parser.sd_param"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSdParam([NotNull] Rfc5424Parser.SdParamContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>headerNilTimestamp</c>
	/// labeled alternative in <see cref="Rfc5424Parser.timestamp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeaderNilTimestamp([NotNull] Rfc5424Parser.HeaderNilTimestampContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>headerTimeStamp</c>
	/// labeled alternative in <see cref="Rfc5424Parser.timestamp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeaderTimeStamp([NotNull] Rfc5424Parser.HeaderTimeStampContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>zeroDigit</c>
	/// labeled alternative in <see cref="Rfc5424Parser.digit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitZeroDigit([NotNull] Rfc5424Parser.ZeroDigitContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>nonZeroDigit</c>
	/// labeled alternative in <see cref="Rfc5424Parser.digit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNonZeroDigit([NotNull] Rfc5424Parser.NonZeroDigitContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>sdElement</c>
	/// labeled alternative in <see cref="Rfc5424Parser.sd_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSdElement([NotNull] Rfc5424Parser.SdElementContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>headerPriority</c>
	/// labeled alternative in <see cref="Rfc5424Parser.pri"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeaderPriority([NotNull] Rfc5424Parser.HeaderPriorityContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>headerNilProcId</c>
	/// labeled alternative in <see cref="Rfc5424Parser.procid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeaderNilProcId([NotNull] Rfc5424Parser.HeaderNilProcIdContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>headerProcId</c>
	/// labeled alternative in <see cref="Rfc5424Parser.procid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeaderProcId([NotNull] Rfc5424Parser.HeaderProcIdContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>headerNilMsgId</c>
	/// labeled alternative in <see cref="Rfc5424Parser.msgid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeaderNilMsgId([NotNull] Rfc5424Parser.HeaderNilMsgIdContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>headerMsgId</c>
	/// labeled alternative in <see cref="Rfc5424Parser.msgid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeaderMsgId([NotNull] Rfc5424Parser.HeaderMsgIdContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>headerVersion</c>
	/// labeled alternative in <see cref="Rfc5424Parser.version"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeaderVersion([NotNull] Rfc5424Parser.HeaderVersionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>headerNilAppName</c>
	/// labeled alternative in <see cref="Rfc5424Parser.app_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeaderNilAppName([NotNull] Rfc5424Parser.HeaderNilAppNameContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>headerAppName</c>
	/// labeled alternative in <see cref="Rfc5424Parser.app_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeaderAppName([NotNull] Rfc5424Parser.HeaderAppNameContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>syslogMsg</c>
	/// labeled alternative in <see cref="Rfc5424Parser.syslog_msg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSyslogMsg([NotNull] Rfc5424Parser.SyslogMsgContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>syslogHeader</c>
	/// labeled alternative in <see cref="Rfc5424Parser.header"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSyslogHeader([NotNull] Rfc5424Parser.SyslogHeaderContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>paramName</c>
	/// labeled alternative in <see cref="Rfc5424Parser.param_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParamName([NotNull] Rfc5424Parser.ParamNameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.syslog_msg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSyslog_msg([NotNull] Rfc5424Parser.Syslog_msgContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.header"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeader([NotNull] Rfc5424Parser.HeaderContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.pri"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPri([NotNull] Rfc5424Parser.PriContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.prival"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrival([NotNull] Rfc5424Parser.PrivalContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.version"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVersion([NotNull] Rfc5424Parser.VersionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.hostname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHostname([NotNull] Rfc5424Parser.HostnameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.app_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitApp_name([NotNull] Rfc5424Parser.App_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.procid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcid([NotNull] Rfc5424Parser.ProcidContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.msgid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMsgid([NotNull] Rfc5424Parser.MsgidContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.timestamp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTimestamp([NotNull] Rfc5424Parser.TimestampContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.full_date"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFull_date([NotNull] Rfc5424Parser.Full_dateContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.date_fullyear"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDate_fullyear([NotNull] Rfc5424Parser.Date_fullyearContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.date_month"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDate_month([NotNull] Rfc5424Parser.Date_monthContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.date_mday"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDate_mday([NotNull] Rfc5424Parser.Date_mdayContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.full_time"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFull_time([NotNull] Rfc5424Parser.Full_timeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.partial_time"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPartial_time([NotNull] Rfc5424Parser.Partial_timeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.time_hour"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTime_hour([NotNull] Rfc5424Parser.Time_hourContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.time_minute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTime_minute([NotNull] Rfc5424Parser.Time_minuteContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.time_second"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTime_second([NotNull] Rfc5424Parser.Time_secondContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.time_secfrac"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTime_secfrac([NotNull] Rfc5424Parser.Time_secfracContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.time_offset"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTime_offset([NotNull] Rfc5424Parser.Time_offsetContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.time_numoffset"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTime_numoffset([NotNull] Rfc5424Parser.Time_numoffsetContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.structured_data"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructured_data([NotNull] Rfc5424Parser.Structured_dataContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.sd_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSd_element([NotNull] Rfc5424Parser.Sd_elementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.sd_param"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSd_param([NotNull] Rfc5424Parser.Sd_paramContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.sd_id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSd_id([NotNull] Rfc5424Parser.Sd_idContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.param_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParam_name([NotNull] Rfc5424Parser.Param_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.param_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParam_value([NotNull] Rfc5424Parser.Param_valueContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.sd_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSd_name([NotNull] Rfc5424Parser.Sd_nameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.msg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMsg([NotNull] Rfc5424Parser.MsgContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.msg_any"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMsg_any([NotNull] Rfc5424Parser.Msg_anyContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.msg_utf8"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMsg_utf8([NotNull] Rfc5424Parser.Msg_utf8Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.bom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBom([NotNull] Rfc5424Parser.BomContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.utf_8_string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUtf_8_string([NotNull] Rfc5424Parser.Utf_8_stringContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.octet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOctet([NotNull] Rfc5424Parser.OctetContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.sp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSp([NotNull] Rfc5424Parser.SpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.printusascii"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrintusascii([NotNull] Rfc5424Parser.PrintusasciiContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.printusasciinospecials"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrintusasciinospecials([NotNull] Rfc5424Parser.PrintusasciinospecialsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.nonzero_digit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNonzero_digit([NotNull] Rfc5424Parser.Nonzero_digitContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.digit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDigit([NotNull] Rfc5424Parser.DigitContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Rfc5424Parser.nilvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNilvalue([NotNull] Rfc5424Parser.NilvalueContext context);
}
} // namespace SyslogServer.grammars