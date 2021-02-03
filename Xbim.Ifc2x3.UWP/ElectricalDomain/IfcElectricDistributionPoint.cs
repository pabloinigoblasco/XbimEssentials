// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.SharedBldgServiceElements;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ElectricalDomain;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcElectricDistributionPoint
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcElectricDistributionPoint : IIfcFlowController
	{
		IfcElectricDistributionPointFunctionEnum @DistributionPointFunction { get;  set; }
		IfcLabel? @UserDefinedFunction { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.ElectricalDomain
{
	[ExpressType("IfcElectricDistributionPoint", 242)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcElectricDistributionPoint : IfcFlowController, IInstantiableEntity, IIfcElectricDistributionPoint, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcElectricDistributionPoint>
	{
		#region IIfcElectricDistributionPoint explicit implementation
		IfcElectricDistributionPointFunctionEnum IIfcElectricDistributionPoint.DistributionPointFunction { 
 
			get { return @DistributionPointFunction; } 
			set { DistributionPointFunction = value;}
		}	
		IfcLabel? IIfcElectricDistributionPoint.UserDefinedFunction { 
 
			get { return @UserDefinedFunction; } 
			set { UserDefinedFunction = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcElectricDistributionPoint(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcElectricDistributionPointFunctionEnum _distributionPointFunction;
		private IfcLabel? _userDefinedFunction;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 28)]
		public IfcElectricDistributionPointFunctionEnum @DistributionPointFunction 
		{ 
			get 
			{
				if(_activated) return _distributionPointFunction;
				Activate();
				return _distributionPointFunction;
			} 
			set
			{
				SetValue( v =>  _distributionPointFunction = v, _distributionPointFunction, value,  "DistributionPointFunction", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 29)]
		public IfcLabel? @UserDefinedFunction 
		{ 
			get 
			{
				if(_activated) return _userDefinedFunction;
				Activate();
				return _userDefinedFunction;
			} 
			set
			{
				SetValue( v =>  _userDefinedFunction = v, _userDefinedFunction, value,  "UserDefinedFunction", 10);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
                    _distributionPointFunction = (IfcElectricDistributionPointFunctionEnum) System.Enum.Parse(typeof (IfcElectricDistributionPointFunctionEnum), value.EnumVal, true);
					return;
				case 9: 
					_userDefinedFunction = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcElectricDistributionPoint other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}