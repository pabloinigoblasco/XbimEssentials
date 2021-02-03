// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProductExtension;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedBldgElements;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStairFlight
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStairFlight : IIfcBuildingElement
	{
		long? @NumberOfRiser { get;  set; }
		long? @NumberOfTreads { get;  set; }
		IfcPositiveLengthMeasure? @RiserHeight { get;  set; }
		IfcPositiveLengthMeasure? @TreadLength { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.SharedBldgElements
{
	[ExpressType("IfcStairFlight", 25)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStairFlight : IfcBuildingElement, IInstantiableEntity, IIfcStairFlight, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcStairFlight>
	{
		#region IIfcStairFlight explicit implementation
		long? IIfcStairFlight.NumberOfRiser { 
 
			get { return @NumberOfRiser; } 
			set { NumberOfRiser = value;}
		}	
		long? IIfcStairFlight.NumberOfTreads { 
 
			get { return @NumberOfTreads; } 
			set { NumberOfTreads = value;}
		}	
		IfcPositiveLengthMeasure? IIfcStairFlight.RiserHeight { 
 
			get { return @RiserHeight; } 
			set { RiserHeight = value;}
		}	
		IfcPositiveLengthMeasure? IIfcStairFlight.TreadLength { 
 
			get { return @TreadLength; } 
			set { TreadLength = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStairFlight(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private long? _numberOfRiser;
		private long? _numberOfTreads;
		private IfcPositiveLengthMeasure? _riserHeight;
		private IfcPositiveLengthMeasure? _treadLength;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 27)]
		public long? @NumberOfRiser 
		{ 
			get 
			{
				if(_activated) return _numberOfRiser;
				Activate();
				return _numberOfRiser;
			} 
			set
			{
				SetValue( v =>  _numberOfRiser = v, _numberOfRiser, value,  "NumberOfRiser", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 28)]
		public long? @NumberOfTreads 
		{ 
			get 
			{
				if(_activated) return _numberOfTreads;
				Activate();
				return _numberOfTreads;
			} 
			set
			{
				SetValue( v =>  _numberOfTreads = v, _numberOfTreads, value,  "NumberOfTreads", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 29)]
		public IfcPositiveLengthMeasure? @RiserHeight 
		{ 
			get 
			{
				if(_activated) return _riserHeight;
				Activate();
				return _riserHeight;
			} 
			set
			{
				SetValue( v =>  _riserHeight = v, _riserHeight, value,  "RiserHeight", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 30)]
		public IfcPositiveLengthMeasure? @TreadLength 
		{ 
			get 
			{
				if(_activated) return _treadLength;
				Activate();
				return _treadLength;
			} 
			set
			{
				SetValue( v =>  _treadLength = v, _treadLength, value,  "TreadLength", 12);
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
					_numberOfRiser = value.IntegerVal;
					return;
				case 9: 
					_numberOfTreads = value.IntegerVal;
					return;
				case 10: 
					_riserHeight = value.RealVal;
					return;
				case 11: 
					_treadLength = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStairFlight other)
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