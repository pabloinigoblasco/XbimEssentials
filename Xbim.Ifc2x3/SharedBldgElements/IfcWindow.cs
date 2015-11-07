// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProductExtension;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.RepresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedBldgElements;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcWindow
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcWindow : IIfcBuildingElement
	{
		IfcPositiveLengthMeasure? @OverallHeight { get; }
		IfcPositiveLengthMeasure? @OverallWidth { get; }
		
	}
}

namespace Xbim.Ifc2x3.SharedBldgElements
{
	[ExpressType("IFCWINDOW", 667)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWindow : IfcBuildingElement, IInstantiableEntity, IIfcWindow, IEqualityComparer<@IfcWindow>, IEquatable<@IfcWindow>
	{
		#region IIfcWindow explicit implementation
		IfcPositiveLengthMeasure? IIfcWindow.OverallHeight { get { return @OverallHeight; } }	
		IfcPositiveLengthMeasure? IIfcWindow.OverallWidth { get { return @OverallWidth; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWindow(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _overallHeight;
		private IfcPositiveLengthMeasure? _overallWidth;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @OverallHeight 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _overallHeight;
				((IPersistEntity)this).Activate(false);
				return _overallHeight;
			} 
			set
			{
				SetValue( v =>  _overallHeight = v, _overallHeight, value,  "OverallHeight");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @OverallWidth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _overallWidth;
				((IPersistEntity)this).Activate(false);
				return _overallWidth;
			} 
			set
			{
				SetValue( v =>  _overallWidth = v, _overallWidth, value,  "OverallWidth");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
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
					_overallHeight = value.RealVal;
					return;
				case 9: 
					_overallWidth = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcWindow other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcWindow
            var root = (@IfcWindow)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcWindow left, @IfcWindow right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcWindow left, @IfcWindow right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcWindow x, @IfcWindow y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcWindow obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}