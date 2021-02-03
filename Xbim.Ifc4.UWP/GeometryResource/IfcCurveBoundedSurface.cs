// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCurveBoundedSurface
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCurveBoundedSurface : IIfcBoundedSurface
	{
		IIfcSurface @BasisSurface { get;  set; }
		IItemSet<IIfcBoundaryCurve> @Boundaries { get; }
		IfcBoolean @ImplicitOuter { get;  set; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcCurveBoundedSurface", 1146)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurveBoundedSurface : IfcBoundedSurface, IInstantiableEntity, IIfcCurveBoundedSurface, IContainsEntityReferences, IEquatable<@IfcCurveBoundedSurface>
	{
		#region IIfcCurveBoundedSurface explicit implementation
		IIfcSurface IIfcCurveBoundedSurface.BasisSurface { 
 
 
			get { return @BasisSurface; } 
			set { BasisSurface = value as IfcSurface;}
		}	
		IItemSet<IIfcBoundaryCurve> IIfcCurveBoundedSurface.Boundaries { 
			get { return new Common.Collections.ProxyItemSet<IfcBoundaryCurve, IIfcBoundaryCurve>( @Boundaries); } 
		}	
		IfcBoolean IIfcCurveBoundedSurface.ImplicitOuter { 
 
			get { return @ImplicitOuter; } 
			set { ImplicitOuter = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurveBoundedSurface(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_boundaries = new ItemSet<IfcBoundaryCurve>( this, 0,  2);
		}

		#region Explicit attribute fields
		private IfcSurface _basisSurface;
		private readonly ItemSet<IfcBoundaryCurve> _boundaries;
		private IfcBoolean _implicitOuter;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcSurface @BasisSurface 
		{ 
			get 
			{
				if(_activated) return _basisSurface;
				Activate();
				return _basisSurface;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _basisSurface = v, _basisSurface, value,  "BasisSurface", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 4)]
		public IItemSet<IfcBoundaryCurve> @Boundaries 
		{ 
			get 
			{
				if(_activated) return _boundaries;
				Activate();
				return _boundaries;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcBoolean @ImplicitOuter 
		{ 
			get 
			{
				if(_activated) return _implicitOuter;
				Activate();
				return _implicitOuter;
			} 
			set
			{
				SetValue( v =>  _implicitOuter = v, _implicitOuter, value,  "ImplicitOuter", 3);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_basisSurface = (IfcSurface)(value.EntityVal);
					return;
				case 1: 
					_boundaries.InternalAdd((IfcBoundaryCurve)value.EntityVal);
					return;
				case 2: 
					_implicitOuter = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCurveBoundedSurface other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@BasisSurface != null)
					yield return @BasisSurface;
				foreach(var entity in @Boundaries)
					yield return entity;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}