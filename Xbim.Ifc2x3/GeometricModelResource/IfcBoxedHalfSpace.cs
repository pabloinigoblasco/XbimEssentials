// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometricModelResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcBoxedHalfSpace
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcBoxedHalfSpace : IIfcHalfSpaceSolid
	{
		IIfcBoundingBox @Enclosure { get; }
		
	}
}

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[ExpressType("IFCBOXEDHALFSPACE", 655)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBoxedHalfSpace : IfcHalfSpaceSolid, IInstantiableEntity, IIfcBoxedHalfSpace, IEqualityComparer<@IfcBoxedHalfSpace>, IEquatable<@IfcBoxedHalfSpace>
	{
		#region IIfcBoxedHalfSpace explicit implementation
		IIfcBoundingBox IIfcBoxedHalfSpace.Enclosure { get { return @Enclosure; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBoxedHalfSpace(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcBoundingBox _enclosure;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcBoundingBox @Enclosure 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _enclosure;
				((IPersistEntity)this).Activate(false);
				return _enclosure;
			} 
			set
			{
				SetValue( v =>  _enclosure = v, _enclosure, value,  "Enclosure");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_enclosure = (IfcBoundingBox)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : NOT ('IFC2X3.IFCCURVEBOUNDEDPLANE' IN TYPEOF(SELF\IfcHalfSpaceSolid.BaseSurface));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcBoxedHalfSpace other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcBoxedHalfSpace
            var root = (@IfcBoxedHalfSpace)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcBoxedHalfSpace left, @IfcBoxedHalfSpace right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcBoxedHalfSpace left, @IfcBoxedHalfSpace right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcBoxedHalfSpace x, @IfcBoxedHalfSpace y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcBoxedHalfSpace obj)
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