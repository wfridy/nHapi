using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
///<summary>
///Represents the ORN_O02_RESPONSE Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: ORN_O02_PATIENT (a Group object) optional </li>
///<li>1: ORN_O02_ORDER (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class ORN_O02_RESPONSE : AbstractGroup {

	///<summary> 
	/// Creates a new ORN_O02_RESPONSE Group.
	///</summary>
	public ORN_O02_RESPONSE(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORN_O02_PATIENT), false, false);
	      this.add(typeof(ORN_O02_ORDER), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORN_O02_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns ORN_O02_PATIENT (a Group object) - creates it if necessary
	///</summary>
	public ORN_O02_PATIENT PATIENT { 
get{
	   ORN_O02_PATIENT ret = null;
	   try {
	      ret = (ORN_O02_PATIENT)this.GetStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of ORN_O02_ORDER (a Group object) - creates it if necessary
	///</summary>
	public ORN_O02_ORDER GetORDER() {
	   ORN_O02_ORDER ret = null;
	   try {
	      ret = (ORN_O02_ORDER)this.GetStructure("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of ORN_O02_ORDER
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public ORN_O02_ORDER GetORDER(int rep) { 
	   return (ORN_O02_ORDER)this.GetStructure("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORN_O02_ORDER 
	 */ 
	public int ORDERRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("ORDER").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}
