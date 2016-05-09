﻿/// <summary>
/// The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// 
/// The Original Code is "ConfDataException.java".  Description: 
/// "This exception will be thrown when an invalid data type is populated" 
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// 
/// Contributor(s): James Agnew
///                Paul Brohman
///                Mitch Delachevrotiere
///                Shawn Dyck
///  				Cory Metcalf
/// 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the "GPL"), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// 
/// </summary>
namespace NHapi.Base.Conf.Classes.Exceptions
{

	/// <summary>
	/// This exception will be thrown when an invalid data type is populated
	/// @author <table><tr>James Agnew</tr>
	///                <tr>Paul Brohman</tr>
	///                <tr>Mitch Delachevrotiere</tr>
	///                <tr>Shawn Dyck</tr>
	/// 				  <tr>Cory Metcalf</tr></table>
	/// </summary>
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @SuppressWarnings("serial") public class ConfDataException extends ConformanceException
	public class ConfDataException : ConformanceException
	{

	   /// <summary>
	   /// Constructor for ConfDataException </summary>
	   /// <param name="val"> the error message to throw </param>
	   public ConfDataException(string val) : base(val)
	   {
	   }

	}
}