// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
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
using Xbim.Ifc2x3.ProductExtension;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcGrid
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcGrid : IIfcProduct
	{
		IEnumerable<IIfcGridAxis> @UAxes { get; }
		IEnumerable<IIfcGridAxis> @VAxes { get; }
		IEnumerable<IIfcGridAxis> @WAxes { get; }
		IEnumerable<IIfcRelContainedInSpatialStructure> @ContainedInStructure {  get; }
		
	}
}

namespace Xbim.Ifc2x3.ProductExtension
{
	[ExpressType("IFCGRID", 564)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGrid : IfcProduct, IInstantiableEntity, IIfcGrid, IEqualityComparer<@IfcGrid>, IEquatable<@IfcGrid>
	{
		#region IIfcGrid explicit implementation
		IEnumerable<IIfcGridAxis> IIfcGrid.UAxes { get { return @UAxes; } }	
		IEnumerable<IIfcGridAxis> IIfcGrid.VAxes { get { return @VAxes; } }	
		IEnumerable<IIfcGridAxis> IIfcGrid.WAxes { get { return @WAxes; } }	
		 
		IEnumerable<IIfcRelContainedInSpatialStructure> IIfcGrid.ContainedInStructure {  get { return @ContainedInStructure; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGrid(IModel model) : base(model) 		{ 
			Model = model; 
			_uAxes = new ItemSet<IfcGridAxis>( this, 0 );
			_vAxes = new ItemSet<IfcGridAxis>( this, 0 );
			_wAxes = new OptionalItemSet<IfcGridAxis>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcGridAxis> _uAxes;
		private ItemSet<IfcGridAxis> _vAxes;
		private OptionalItemSet<IfcGridAxis> _wAxes;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcGridAxis> @UAxes 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _uAxes;
				((IPersistEntity)this).Activate(false);
				return _uAxes;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcGridAxis> @VAxes 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _vAxes;
				((IPersistEntity)this).Activate(false);
				return _vAxes;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcGridAxis> @WAxes 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _wAxes;
				((IPersistEntity)this).Activate(false);
				return _wAxes;
			} 
		}	
		#endregion



		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelContainedInSpatialStructure> @ContainedInStructure 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelContainedInSpatialStructure>(e => e.RelatedElements != null &&  e.RelatedElements.Contains(this));
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
					if (_uAxes == null) _uAxes = new ItemSet<IfcGridAxis>( this );
					_uAxes.InternalAdd((IfcGridAxis)value.EntityVal);
					return;
				case 8: 
					if (_vAxes == null) _vAxes = new ItemSet<IfcGridAxis>( this );
					_vAxes.InternalAdd((IfcGridAxis)value.EntityVal);
					return;
				case 9: 
					if (_wAxes == null) _wAxes = new OptionalItemSet<IfcGridAxis>( this );
					_wAxes.InternalAdd((IfcGridAxis)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR41:	WR41 : EXISTS(SELF\IfcProduct.ObjectPlacement);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcGrid other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcGrid
            var root = (@IfcGrid)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcGrid left, @IfcGrid right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcGrid left, @IfcGrid right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcGrid x, @IfcGrid y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcGrid obj)
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