// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcAxis2Placement3D
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcAxis2Placement3D : IIfcPlacement, IfcAxis2Placement
	{
		IIfcDirection @Axis { get;  set; }
		IIfcDirection @RefDirection { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IfcAxis2Placement3D", 448)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAxis2Placement3D : IfcPlacement, IInstantiableEntity, IIfcAxis2Placement3D, IContainsEntityReferences, IEquatable<@IfcAxis2Placement3D>
	{
		#region IIfcAxis2Placement3D explicit implementation
		IIfcDirection IIfcAxis2Placement3D.Axis { 
 
 
			get { return @Axis; } 
			set { Axis = value as IfcDirection;}
		}	
		IIfcDirection IIfcAxis2Placement3D.RefDirection { 
 
 
			get { return @RefDirection; } 
			set { RefDirection = value as IfcDirection;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAxis2Placement3D(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcDirection _axis;
		private IfcDirection _refDirection;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcDirection @Axis 
		{ 
			get 
			{
				if(_activated) return _axis;
				Activate();
				return _axis;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _axis = v, _axis, value,  "Axis", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcDirection @RefDirection 
		{ 
			get 
			{
				if(_activated) return _refDirection;
				Activate();
				return _refDirection;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _refDirection = v, _refDirection, value,  "RefDirection", 3);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 3 }, new int [] { 3 }, 0)]
		public List<Common.Geometry.XbimVector3D> @P 
		{
			get 
			{
				//## Getter for P
                var p = new List<Common.Geometry.XbimVector3D>(3);
                if (RefDirection == null && Axis == null)
                {
                    p.Add(new Common.Geometry.XbimVector3D(1, 0, 0));
                    p.Add(new Common.Geometry.XbimVector3D(0, 1, 0));
                    p.Add(new Common.Geometry.XbimVector3D(0, 0, 1));
                }
                else if (RefDirection != null && Axis != null)
                {
                    var za = _axis.XbimVector3D();
                    za.Normalized();
                    var xa = _refDirection.XbimVector3D();
                    xa.Normalized();
                    var ya = Common.Geometry.XbimVector3D.CrossProduct(za, xa);
                    ya.Normalized();
                    p.Add(xa);
                    p.Add(ya);
                    p.Add(za);
                }
                else
                    throw new ArgumentException("RefDirection and Axis must be noth either null or both defined");
                return p;
				//##
			}
		}

		#endregion


		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_axis = (IfcDirection)(value.EntityVal);
					return;
				case 2: 
					_refDirection = (IfcDirection)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAxis2Placement3D other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Location != null)
					yield return @Location;
				if (@Axis != null)
					yield return @Axis;
				if (@RefDirection != null)
					yield return @RefDirection;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}