// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.RepresentationResource
{
	public partial class @IfcGeometricRepresentationContext : IIfcGeometricRepresentationContext
	{

		[CrossSchemaAttribute(typeof(IIfcGeometricRepresentationContext), 3)]
		Ifc4.GeometryResource.IfcDimensionCount IIfcGeometricRepresentationContext.CoordinateSpaceDimension 
		{ 
			get
			{
				return new Ifc4.GeometryResource.IfcDimensionCount(CoordinateSpaceDimension);
			} 
			set
			{
				CoordinateSpaceDimension = new GeometryResource.IfcDimensionCount(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcGeometricRepresentationContext), 4)]
		Ifc4.MeasureResource.IfcReal? IIfcGeometricRepresentationContext.Precision 
		{ 
			get
			{
				if (!Precision.HasValue) return null;
				return new Ifc4.MeasureResource.IfcReal(Precision.Value);
			} 
			set
			{
				Precision = value.HasValue ? 
					new MeasureResource.IfcReal(value.Value) :  
					 new MeasureResource.IfcReal?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcGeometricRepresentationContext), 5)]
		IIfcAxis2Placement IIfcGeometricRepresentationContext.WorldCoordinateSystem 
		{ 
			get
			{
				if (WorldCoordinateSystem == null) return null;
				var ifcaxis2placement2d = WorldCoordinateSystem as GeometryResource.IfcAxis2Placement2D;
				if (ifcaxis2placement2d != null) 
					return ifcaxis2placement2d;
				var ifcaxis2placement3d = WorldCoordinateSystem as GeometryResource.IfcAxis2Placement3D;
				if (ifcaxis2placement3d != null) 
					return ifcaxis2placement3d;
				return null;
			} 
			set
			{
				if (value == null)
				{
					WorldCoordinateSystem = null;
					return;
				}	
				var ifcaxis2placement2d = value as GeometryResource.IfcAxis2Placement2D;
				if (ifcaxis2placement2d != null) 
				{
					WorldCoordinateSystem = ifcaxis2placement2d;
					return;
				}
				var ifcaxis2placement3d = value as GeometryResource.IfcAxis2Placement3D;
				if (ifcaxis2placement3d != null) 
				{
					WorldCoordinateSystem = ifcaxis2placement3d;
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcGeometricRepresentationContext), 6)]
		IIfcDirection IIfcGeometricRepresentationContext.TrueNorth 
		{ 
			get
			{
				return TrueNorth;
			} 
			set
			{
				TrueNorth = value as GeometryResource.IfcDirection;
				
			}
		}
		IEnumerable<IIfcGeometricRepresentationSubContext> IIfcGeometricRepresentationContext.HasSubContexts 
		{ 
			get
			{
				return Model.Instances.Where<IIfcGeometricRepresentationSubContext>(e => (e.ParentContext as IfcGeometricRepresentationContext) == this, "ParentContext", this);
			} 
		}
		IEnumerable<IIfcCoordinateOperation> IIfcGeometricRepresentationContext.HasCoordinateOperation 
		{ 
			get
			{
				return Model.Instances.Where<IIfcCoordinateOperation>(e => (e.SourceCRS as IfcGeometricRepresentationContext) == this, "SourceCRS", this);
			} 
		}
	//## Custom code
	//##
	}
}