using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V22.Datatype
{

///<summary>
/// <p>The HL7 CM_RANGE (Wertebereich) data type.  Consists of the following components: </p><ol>
/// <li>Low Value (CE)</li>
/// <li>High Value (CE)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_RANGE : AbstractComposite{
	private IType[] data;

	///<summary>
	/// Creates a CM_RANGE.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_RANGE(IMessage message) : this(message, null){}

	///<summary>
	/// Creates a CM_RANGE.
	/// <param name="message">The Message to which this Type belongs</param>
	/// <param name="description">The description of this type</param>
	///</summary>
	public CM_RANGE(IMessage message, string description) : base(message, description){
		data = new IType[2];
		data[0] = new CE(message,"Low Value");
		data[1] = new CE(message,"High Value");
	}

	///<summary>
	/// Returns an array containing the data elements.
	///</summary>
	public override IType[] Components
	{ 
		get{
			return this.data; 
		}
	}

	///<summary>
	/// Returns an individual data component.
	/// @throws DataTypeException if the given element number is out of range.
	///<param name="index">The index item to get (zero based)</param>
	///<returns>The data component (as a type) at the requested number (ordinal)</returns>
	///</summary>
	public override IType this[int index] { 

get{
		try { 
			return this.data[index]; 
		} catch (System.ArgumentOutOfRangeException) { 
			throw new DataTypeException("Element " + index + " doesn't exist in 2 element CM_RANGE composite"); 
		} 
	} 
	} 
	///<summary>
	/// Returns Low Value (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE LowValue {
get{
	   CE ret = null;
	   try {
	      ret = (CE)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns High Value (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE HighValue {
get{
	   CE ret = null;
	   try {
	      ret = (CE)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}