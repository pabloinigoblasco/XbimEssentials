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

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.ArchitectureDomain
{
	public partial class @IfcPermeableCoveringProperties : IIfcPermeableCoveringProperties
	{

		[CrossSchemaAttribute(typeof(IIfcPermeableCoveringProperties), 5)]
		Ifc4.Interfaces.IfcPermeableCoveringOperationEnum IIfcPermeableCoveringProperties.OperationType 
		{ 
			get
			{
				//## Custom code to handle enumeration of OperationType
				//##
				switch (OperationType)
				{
					case IfcPermeableCoveringOperationEnum.GRILL:
						return Ifc4.Interfaces.IfcPermeableCoveringOperationEnum.GRILL;
					case IfcPermeableCoveringOperationEnum.LOUVER:
						return Ifc4.Interfaces.IfcPermeableCoveringOperationEnum.LOUVER;
					case IfcPermeableCoveringOperationEnum.SCREEN:
						return Ifc4.Interfaces.IfcPermeableCoveringOperationEnum.SCREEN;
					case IfcPermeableCoveringOperationEnum.USERDEFINED:
						//## Optional custom handling of OperationType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcPermeableCoveringOperationEnum.USERDEFINED;
					case IfcPermeableCoveringOperationEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcPermeableCoveringOperationEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of OperationType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcPermeableCoveringOperationEnum.GRILL:
						OperationType = IfcPermeableCoveringOperationEnum.GRILL;
						return;
					case Ifc4.Interfaces.IfcPermeableCoveringOperationEnum.LOUVER:
						OperationType = IfcPermeableCoveringOperationEnum.LOUVER;
						return;
					case Ifc4.Interfaces.IfcPermeableCoveringOperationEnum.SCREEN:
						OperationType = IfcPermeableCoveringOperationEnum.SCREEN;
						return;
					case Ifc4.Interfaces.IfcPermeableCoveringOperationEnum.USERDEFINED:
						OperationType = IfcPermeableCoveringOperationEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcPermeableCoveringOperationEnum.NOTDEFINED:
						OperationType = IfcPermeableCoveringOperationEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPermeableCoveringProperties), 6)]
		Ifc4.Interfaces.IfcWindowPanelPositionEnum IIfcPermeableCoveringProperties.PanelPosition 
		{ 
			get
			{
				//## Custom code to handle enumeration of PanelPosition
				//##
				switch (PanelPosition)
				{
					case IfcWindowPanelPositionEnum.LEFT:
						return Ifc4.Interfaces.IfcWindowPanelPositionEnum.LEFT;
					case IfcWindowPanelPositionEnum.MIDDLE:
						return Ifc4.Interfaces.IfcWindowPanelPositionEnum.MIDDLE;
					case IfcWindowPanelPositionEnum.RIGHT:
						return Ifc4.Interfaces.IfcWindowPanelPositionEnum.RIGHT;
					case IfcWindowPanelPositionEnum.BOTTOM:
						return Ifc4.Interfaces.IfcWindowPanelPositionEnum.BOTTOM;
					case IfcWindowPanelPositionEnum.TOP:
						return Ifc4.Interfaces.IfcWindowPanelPositionEnum.TOP;
					case IfcWindowPanelPositionEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcWindowPanelPositionEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PanelPosition
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcWindowPanelPositionEnum.LEFT:
						PanelPosition = IfcWindowPanelPositionEnum.LEFT;
						return;
					case Ifc4.Interfaces.IfcWindowPanelPositionEnum.MIDDLE:
						PanelPosition = IfcWindowPanelPositionEnum.MIDDLE;
						return;
					case Ifc4.Interfaces.IfcWindowPanelPositionEnum.RIGHT:
						PanelPosition = IfcWindowPanelPositionEnum.RIGHT;
						return;
					case Ifc4.Interfaces.IfcWindowPanelPositionEnum.BOTTOM:
						PanelPosition = IfcWindowPanelPositionEnum.BOTTOM;
						return;
					case Ifc4.Interfaces.IfcWindowPanelPositionEnum.TOP:
						PanelPosition = IfcWindowPanelPositionEnum.TOP;
						return;
					case Ifc4.Interfaces.IfcWindowPanelPositionEnum.NOTDEFINED:
						PanelPosition = IfcWindowPanelPositionEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPermeableCoveringProperties), 7)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcPermeableCoveringProperties.FrameDepth 
		{ 
			get
			{
				if (!FrameDepth.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(FrameDepth.Value);
			} 
			set
			{
				FrameDepth = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPermeableCoveringProperties), 8)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcPermeableCoveringProperties.FrameThickness 
		{ 
			get
			{
				if (!FrameThickness.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(FrameThickness.Value);
			} 
			set
			{
				FrameThickness = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPermeableCoveringProperties), 9)]
		IIfcShapeAspect IIfcPermeableCoveringProperties.ShapeAspectStyle 
		{ 
			get
			{
				return ShapeAspectStyle;
			} 
			set
			{
				ShapeAspectStyle = value as RepresentationResource.IfcShapeAspect;
				
			}
		}
	//## Custom code
	//##
	}
}