// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.RepresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRepresentationMap
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRepresentationMap : IPersistEntity
	{
		IIfcAxis2Placement @MappingOrigin { get;  set; }
		IIfcRepresentation @MappedRepresentation { get;  set; }
		IEnumerable<IIfcMappedItem> @MapUsage {  get; }
	
	}
}

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IfcRepresentationMap", 95)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRepresentationMap : PersistEntity, IInstantiableEntity, IIfcRepresentationMap, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRepresentationMap>
	{
		#region IIfcRepresentationMap explicit implementation
		IIfcAxis2Placement IIfcRepresentationMap.MappingOrigin { 
 
 
			get { return @MappingOrigin; } 
			set { MappingOrigin = value as IfcAxis2Placement;}
		}	
		IIfcRepresentation IIfcRepresentationMap.MappedRepresentation { 
 
 
			get { return @MappedRepresentation; } 
			set { MappedRepresentation = value as IfcRepresentation;}
		}	
		 
		IEnumerable<IIfcMappedItem> IIfcRepresentationMap.MapUsage {  get { return @MapUsage; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRepresentationMap(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcAxis2Placement _mappingOrigin;
		private IfcRepresentation _mappedRepresentation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcAxis2Placement @MappingOrigin 
		{ 
			get 
			{
				if(_activated) return _mappingOrigin;
				Activate();
				return _mappingOrigin;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _mappingOrigin = v, _mappingOrigin, value,  "MappingOrigin", 1);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 2)]
		public IfcRepresentation @MappedRepresentation 
		{ 
			get 
			{
				if(_activated) return _mappedRepresentation;
				Activate();
				return _mappedRepresentation;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _mappedRepresentation = v, _mappedRepresentation, value,  "MappedRepresentation", 2);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("MappingSource")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 3)]
		public IEnumerable<IfcMappedItem> @MapUsage 
		{ 
			get 
			{
				return Model.Instances.Where<IfcMappedItem>(e => Equals(e.MappingSource), "MappingSource", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_mappingOrigin = (IfcAxis2Placement)(value.EntityVal);
					return;
				case 1: 
					_mappedRepresentation = (IfcRepresentation)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRepresentationMap other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@MappingOrigin != null)
					yield return @MappingOrigin;
				if (@MappedRepresentation != null)
					yield return @MappedRepresentation;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@MappedRepresentation != null)
					yield return @MappedRepresentation;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}