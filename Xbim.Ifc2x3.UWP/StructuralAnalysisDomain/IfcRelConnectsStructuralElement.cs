// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.ProductExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.StructuralAnalysisDomain;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelConnectsStructuralElement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelConnectsStructuralElement : IIfcRelConnects
	{
		IIfcElement @RelatingElement { get;  set; }
		IIfcStructuralMember @RelatedStructuralMember { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[ExpressType("IfcRelConnectsStructuralElement", 413)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelConnectsStructuralElement : IfcRelConnects, IInstantiableEntity, IIfcRelConnectsStructuralElement, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelConnectsStructuralElement>
	{
		#region IIfcRelConnectsStructuralElement explicit implementation
		IIfcElement IIfcRelConnectsStructuralElement.RelatingElement { 
 
 
			get { return @RelatingElement; } 
			set { RelatingElement = value as IfcElement;}
		}	
		IIfcStructuralMember IIfcRelConnectsStructuralElement.RelatedStructuralMember { 
 
 
			get { return @RelatedStructuralMember; } 
			set { RelatedStructuralMember = value as IfcStructuralMember;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelConnectsStructuralElement(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcElement _relatingElement;
		private IfcStructuralMember _relatedStructuralMember;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcElement @RelatingElement 
		{ 
			get 
			{
				if(_activated) return _relatingElement;
				Activate();
				return _relatingElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingElement = v, _relatingElement, value,  "RelatingElement", 5);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 6)]
		public IfcStructuralMember @RelatedStructuralMember 
		{ 
			get 
			{
				if(_activated) return _relatedStructuralMember;
				Activate();
				return _relatedStructuralMember;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatedStructuralMember = v, _relatedStructuralMember, value,  "RelatedStructuralMember", 6);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_relatingElement = (IfcElement)(value.EntityVal);
					return;
				case 5: 
					_relatedStructuralMember = (IfcStructuralMember)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelConnectsStructuralElement other)
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
				if (@RelatingElement != null)
					yield return @RelatingElement;
				if (@RelatedStructuralMember != null)
					yield return @RelatedStructuralMember;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingElement != null)
					yield return @RelatingElement;
				if (@RelatedStructuralMember != null)
					yield return @RelatedStructuralMember;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}