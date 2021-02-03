// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedComponentElements;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcChamferEdgeFeature
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcChamferEdgeFeature : IIfcEdgeFeature
	{
		IfcPositiveLengthMeasure? @Width { get;  set; }
		IfcPositiveLengthMeasure? @Height { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.SharedComponentElements
{
	[ExpressType("IfcChamferEdgeFeature", 765)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcChamferEdgeFeature : IfcEdgeFeature, IInstantiableEntity, IIfcChamferEdgeFeature, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcChamferEdgeFeature>
	{
		#region IIfcChamferEdgeFeature explicit implementation
		IfcPositiveLengthMeasure? IIfcChamferEdgeFeature.Width { 
 
			get { return @Width; } 
			set { Width = value;}
		}	
		IfcPositiveLengthMeasure? IIfcChamferEdgeFeature.Height { 
 
			get { return @Height; } 
			set { Height = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcChamferEdgeFeature(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _width;
		private IfcPositiveLengthMeasure? _height;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 29)]
		public IfcPositiveLengthMeasure? @Width 
		{ 
			get 
			{
				if(_activated) return _width;
				Activate();
				return _width;
			} 
			set
			{
				SetValue( v =>  _width = v, _width, value,  "Width", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 30)]
		public IfcPositiveLengthMeasure? @Height 
		{ 
			get 
			{
				if(_activated) return _height;
				Activate();
				return _height;
			} 
			set
			{
				SetValue( v =>  _height = v, _height, value,  "Height", 11);
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
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
					_width = value.RealVal;
					return;
				case 10: 
					_height = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcChamferEdgeFeature other)
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